using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using BeerProduction.DAL;
using BeerProduction.DAL.Models;
using BeerProduction.DAL.Repos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Workstation.ServiceModel.Ua;
using Workstation.ServiceModel.Ua.Channels;
using Serene1.SubscriptionHub;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace BeerProduction.OPC
{
    public sealed class OpcStart
    {
        private static  OpcStart instance = null;
        private static readonly object padlock = new object();
        private static string discoveryUrl = $"opc.tcp://localhost:4840";
        private CancellationTokenSource cts = new CancellationTokenSource();
        public static DateTime startTime;

        private static UnitofWork _uow = new UnitofWork();

        public static OpcStart Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance != null) return instance;
                    instance = new OpcStart();
                    return instance;

                }
            }
        }

        private OpcStart()
        {
            startTime = new DateTime();
            Task.Run(() => ReadSubscribed(cts.Token));
        }

        #region OPC generic methods

        public void ReadSubscribedClose()
        {
            cts.Cancel();
        }

        private static IHubConnectionContext<dynamic> Clients = GlobalHost.ConnectionManager.GetHubContext<SubscriptionHub>().Clients;


        public static int prodProc { get; set; } // Product produced
        public static int acceptableProduct { get; set; } //Acceptable products
        public static int unacceptableProduct { get; set; } //Unacceptable products
        public static float nextBatchID { get; set; } //Next batch ID
        public static float nextProductID { get; set; } //Next type of beer in batch
        public static float nextProductAmount { get; set; } //Next amount of product
        public static float temperature { get; set; } //Current temperature
        public static float humidity { get; set; } //Current humidity
        public static float vibration { get; set; } //Current vibration
        public static float machinespeed { get; set; } //Current machine speed in products per minute
        public static float malt { get; set; } //The level of malt left from 0-43750? <-- Check 35000/0.8 = x/1.
        public static float maltPercentage { get { return getPercentage(malt); } } //Get malt in percentage
        public static float hops { get; set; } //The level of hops left
        public static float hopsPercentage { get { return getPercentage(hops); } } //Get hops in percentage
        public static float barley { get; set; } //The level of barley left 
        public static float barleyPercentage { get { return getPercentage(barley); } } //Get barley in percentage
        public static float wheat { get; set; } //The level of wheat left
        public static float wheatPercentage { get { return getPercentage(wheat); } } //Get wheat in percentage
        public static float yeast { get; set; } //The level of yeast left
        public static float yeastPercentage { get { return getPercentage(yeast); } } //Get yeast in percentage
        private static float maxValue = 35000; //Max value of ingredients
        public static float State { get; set; } //The current state of the machine
        public static int CmdCntrl { get; set; } //

        public static float CalculateOEE(int speed, int maxSpeed, int total, int good, float actualTime)
        {
            float  plannedTime = (float) total / speed; //Minutes it takes to make all the products planned

            float availablity =  plannedTime / actualTime; //The relationship between the planned time and actual time.
            float performance = (float) (speed / maxSpeed); //Percentage of max speed
            float quality = (float) (good / total); //Percentage of good products

            return  performance * quality * availablity * 100; //Calculate OEE
        }


        private static float getPercentage(float ingredient)
        {
            return (float) Math.Round(ingredient / maxValue * 100, 2); //Returns percentage left in 2 decimals
        }

        public static async Task ReadSubscribed(CancellationToken token = default(CancellationToken))
        {
            {

                // setup logger
                var loggerFactory = new LoggerFactory();
                loggerFactory.AddConsole(LogLevel.Information);
                //var logger = loggerFactory?.CreateLogger<Program>();

                // Describe this app.
                var appDescription = new ApplicationDescription()
                {
                    ApplicationName = "DataLoggingConsole",
                    ApplicationUri = $"urn:{System.Net.Dns.GetHostName()}:DataLoggingConsole",
                    ApplicationType = ApplicationType.Client,
                };

                // Create a certificate store on disk.
                var certificateStore = new DirectoryStore(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DataLoggingConsole", "pki"));

                // Create array of NodeIds to log.
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        // Discover endpoints.
                        var getEndpointsRequest = new GetEndpointsRequest
                        {
                            EndpointUrl = discoveryUrl,
                            ProfileUris = new[] {TransportProfileUris.UaTcpTransport}
                        };
                        var getEndpointsResponse = await UaTcpDiscoveryService.GetEndpointsAsync(getEndpointsRequest)
                            .ConfigureAwait(false);
                        if (getEndpointsResponse.Endpoints == null || getEndpointsResponse.Endpoints.Length == 0)
                        {
                            throw new InvalidOperationException($"'{discoveryUrl}' returned no endpoints.");
                        }

                        // Choose the endpoint with highest security level.
                        var remoteEndpoint = getEndpointsResponse.Endpoints.OrderBy(e => e.SecurityLevel).Last();

                        // Create a session with the server.
                        var channel = new UaTcpSessionChannel(appDescription, certificateStore,
                            async e => GetIUserIdentity(remoteEndpoint).GetAwaiter().GetResult(),
                            remoteEndpoint, loggerFactory);
                        try
                        {
                            await channel.OpenAsync();

                            var subscriptionRequest = new CreateSubscriptionRequest
                            {
                                RequestedPublishingInterval = 1000,
                                RequestedMaxKeepAliveCount = 10,
                                RequestedLifetimeCount = 30,
                                PublishingEnabled = true
                            };
                            var subscriptionResponse = await channel.CreateSubscriptionAsync(subscriptionRequest);
                            var id = subscriptionResponse.SubscriptionId;

                            var itemsToCreate = new MonitoredItemCreateRequest[]
                            {
                                #region MonitoredItems
                                
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Admin.ProdProcessedCount"), AttributeId = AttributeIds.Value}, //ProdProcessedCount
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 1, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },


                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[0].Value"), AttributeId = AttributeIds.Value}, //Next batch ID
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 2, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },

                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[1].Value"), AttributeId = AttributeIds.Value}, //Next product ID
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 3, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[2].Value"), AttributeId = AttributeIds.Value}, //Amount of product in next batch
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 4, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                #region Sensors
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Status.Parameter[2].Value"), AttributeId = AttributeIds.Value}, //Humidity
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 5, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Status.Parameter[3].Value"), AttributeId = AttributeIds.Value}, //Temperature
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 6, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Status.Parameter[4].Value"), AttributeId = AttributeIds.Value}, //Vibration
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 7, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Status.MachSpeed"), AttributeId = AttributeIds.Value}, //MachineSpeed
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 8, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                #endregion

                                #region Ingredients
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Inventory.Malt"), AttributeId = AttributeIds.Value}, //Malt
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 9, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Inventory.Barley"), AttributeId = AttributeIds.Value}, //Barley
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 10, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Inventory.Hops"), AttributeId = AttributeIds.Value}, //Hops
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 11, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Inventory.Wheat"), AttributeId = AttributeIds.Value}, //Wheat
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 12, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Inventory.Yeast"), AttributeId = AttributeIds.Value}, //Yeast
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 13, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Command.CntrlCmd"), AttributeId = AttributeIds.Value}, //SetControlCommand
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 14, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                }
                                #endregion
                                ,
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Product.good"), AttributeId = AttributeIds.Value}, //Acceptable products
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 15, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Product.bad"), AttributeId = AttributeIds.Value}, //Unacceptable products
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 16, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }
                                },
                                new MonitoredItemCreateRequest
                                {
                                    ItemToMonitor = new ReadValueId
                                        {NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Status.StateCurrent"), AttributeId = AttributeIds.Value}, //state
                                    MonitoringMode = MonitoringMode.Reporting,
                                    RequestedParameters = new MonitoringParameters
                                    {
                                        ClientHandle = 17, SamplingInterval = -1, QueueSize = 0, DiscardOldest = true
                                    }

                                }



                                #endregion

                            };

                         
                            var itemsRequest = new CreateMonitoredItemsRequest
                            {
                                SubscriptionId = id,
                                ItemsToCreate = itemsToCreate,
                            };
                            var itemsResponse = await channel.CreateMonitoredItemsAsync(itemsRequest);

                            var subToken = channel.Where(pr => pr.SubscriptionId == id).Subscribe(pr =>
                            {
                                // loop through all the data change notifications
                                var dcns = pr.NotificationMessage.NotificationData.OfType<DataChangeNotification>();
                                foreach (var dcn in dcns)
                                {   
                                    foreach (var min in dcn.MonitoredItems)
                                    {

                                        switch (min.ClientHandle)
                                        {
                                            case 1:
                                                prodProc = (int) min.Value.Value;

                                                ProductProcessed productProcessed = new ProductProcessed()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (int)min.Value.Value
                                                };
                                                Clients.All.updateProdProc(min.Value.Value);
                                                _uow.ProductProcessedRepos.Add(productProcessed);
                                                _uow.SaveChanges();

                                                break;
                                            case 2:

                                                nextBatchID = (float) min.Value.Value;

                                                NextBatchID nxtBatchID = new NextBatchID()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };

                                                _uow.NextBatchIDRepos.Add(nxtBatchID);
                                                _uow.SaveChanges();

                                                break;
                                            case 3:

                                                nextProductID = (float) min.Value.Value;

                                                NextProductID nxtProductID = new NextProductID()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };

                                                _uow.NextProductIDRepos.Add(nxtProductID);
                                                _uow.SaveChanges();

                                                break;

                                            case 4:

                                                nextProductAmount = (float) min.Value.Value;

                                                NextProductAmount nextProductAmt = new NextProductAmount()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };

                                                _uow.NextProductAmountRepos.Add(nextProductAmt);
                                                _uow.SaveChanges();

                                                break;
                                            case 5:

                                                humidity = (float) min.Value.Value;

                                                Humidity humid = new Humidity()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };

                                                _uow.HumidityRepos.Add(humid);
                                                _uow.SaveChanges();

                                                break;
                                            case 6:
                                                temperature = (float) min.Value.Value;

                                                Temperature temp = new Temperature
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };
                                                
                                                _uow.TemperatureRepos.Add(temp);
                                                _uow.SaveChanges();

                                                break;
                                            case 7:
                                                vibration = (float) min.Value.Value;

                                                Vibration vibra = new Vibration()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };

                                                _uow.VibrationRepos.Add(vibra);
                                                _uow.SaveChanges();

                                                break;
                                            case 8:
                                                machinespeed = (float) min.Value.Value;

                                                MachineSpeed machineSpeed = new MachineSpeed()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (float)min.Value.Value
                                                };

                                                _uow.MachineSpeedRepos.Add(machineSpeed);
                                                _uow.SaveChanges();

                                                break;
                                            case 9:
                                                malt = (float) min.Value.Value;
                                                break;

                                            case 10:
                                                barley = (float) min.Value.Value;
                                                break;

                                            case 11:
                                                hops = (float) min.Value.Value;
                                                break;

                                            case 12:
                                                wheat = (float) min.Value.Value;
                                                break;

                                            case 13:
                                                yeast = (float) min.Value.Value;
                                                break;
                                            case 14:
                                                CmdCntrl = (Int32) min.Value.Value;
                                                //Log state change to database NOT update GUI
                                                SetControlCommand setControlCommand = new SetControlCommand()
                                                {
                                                    DateTime = DateTime.Now,
                                                    Value = (Int32)min.Value.Value
                                                };

                                                _uow.SetControlCommandRepos.Add(setControlCommand);
                                                _uow.SaveChanges();

                                                break;
                                            case 17:

                                                State = (int)min.Value.Value; 
                                                
                                                break;
                                        }

                                    }
                                }
                            });

                            while (!token.IsCancellationRequested)
                            {
                                await Task.Delay(500);
                            }
                        }
                        catch
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }

                    //try
                    //{
                    //    await Task.Delay(cycleTime, token);
                    //}
                    //catch
                    //{
                    //}
                }
            }
     }


        private static async Task Write(List<NodeId> nodesIds, DataValue dataval )
        {


            // setup logger
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddDebug(LogLevel.Debug);

            // Describe this app.
            var appDescription = new ApplicationDescription()
            {
                ApplicationName = "DataLoggingConsole",
                ApplicationUri = $"urn:{System.Net.Dns.GetHostName()}:DataLoggingConsole",
                ApplicationType = ApplicationType.Client,
            };

            // Create a certificate store on disk.
            var certificateStore = new DirectoryStore(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DataLoggingConsole", "pki"));

            // Create array of NodeIds to log.
            var nodeIds = nodesIds.ToArray();
                try
                {
                    // Discover endpoints.
                    var getEndpointsRequest = new GetEndpointsRequest
                    {
                        EndpointUrl = discoveryUrl,
                        ProfileUris = new[] { TransportProfileUris.UaTcpTransport }
                    };
                    var getEndpointsResponse = await UaTcpDiscoveryService.GetEndpointsAsync(getEndpointsRequest).ConfigureAwait(false);
                    if (getEndpointsResponse.Endpoints == null || getEndpointsResponse.Endpoints.Length == 0)
                    {
                        throw new InvalidOperationException($"'{discoveryUrl}' returned no endpoints.");
                    }

                    // Choose the endpoint with highest security level.
                    var remoteEndpoint = getEndpointsResponse.Endpoints.OrderBy(e => e.SecurityLevel).Last();
                    // Create a session with the server.
                    var session = new UaTcpSessionChannel(appDescription, certificateStore, async e => GetIUserIdentity(remoteEndpoint).GetAwaiter().GetResult(), remoteEndpoint, loggerFactory);
                    try
                    {
                        await session.OpenAsync();

                        RegisterNodesResponse registerNodesResponse = null;

                        if (true) // True registers the nodeIds to improve performance of the server.
                        {
                            // Register array of nodes to read.
                            var registerNodesRequest = new RegisterNodesRequest
                            {
                                NodesToRegister = nodeIds
                            };
                            registerNodesResponse = await session.RegisterNodesAsync(registerNodesRequest);
                        }

                     WriteRequest writeRequest = new WriteRequest();
                        writeRequest.NodesToWrite = new WriteValue[1]
                        {
                            new WriteValue()
                            {
                                NodeId = nodeIds[0],
                                AttributeId = AttributeIds.Value,
                                Value = dataval
                            }
                        };
                        WriteRequest request = writeRequest;
                        StatusCode statusCode;
                    // write the nodes.
                    statusCode = (await session.WriteAsync(request).ConfigureAwait(false)).Results[0]; ;


                    }
                    catch
                    {
                        await session.AbortAsync();
                        throw;
                    }
                    await session.CloseAsync();
                }

                catch (Exception e)
                {
                    // ignored
                }
        }

        private static async Task<IUserIdentity> GetIUserIdentity(EndpointDescription remoteEndpoint)
        {
            // Choose a User Identity.
            IUserIdentity userIdentity = null;
            if (remoteEndpoint.UserIdentityTokens.Any(p => p.TokenType == UserTokenType.Anonymous))
            {
                userIdentity = new AnonymousIdentity();
            }
            else if (remoteEndpoint.UserIdentityTokens.Any(p => p.TokenType == UserTokenType.UserName))
            {
                // If a username / password is requested, provide from .config file.
                userIdentity = new UserNameIdentity("sdu", "1234");
            }
            else
            {
                throw new InvalidOperationException("Server must accept Anonymous or UserName identity.");
            }

            return userIdentity;
        }
          
        #endregion

        public bool SetCntrlCmd(Int32 data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.CntrlCmd") /*CntrlCmd*/};
                DataValue val = new DataValue(new Variant(data));
                Write(nodeIds, val).Start();

                foreach (var nodeID in nodeIds)
                {
                    Console.WriteLine("NodeID: " + nodeID.ToString());
                }

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetNextBatchID(Object data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[0]") /*Parameter[0]*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Int16);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetNextProductID(Object data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[1]") /*Parameter[1]*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Int16);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetNextProductAmount(Object data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[2]") /*Parameter[2]*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Int16);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetMachSpeed(Single data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.MachSpeed") /*MachSpeed*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Double);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetCmdChangeRequest(Boolean data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.CmdChangeRequest") /*CmdChangeRequest*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Boolean);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetBatchID(Int32 data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter.Parameter[0]") /*Parameter.Parameter[0]*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Int32);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SetBeerTypeID(Int32 data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId> { NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter.Parameter[1]") /*Parameter.Parameter[1]*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Int32);
                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetProductID(Single data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId>
                    {NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[1].Value") /*Value*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Float);

                Write(nodeIds, val).Start();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SetBatchAmount(Int32 data)
        {
            try
            {
                List<NodeId> nodeIds = new List<NodeId>
                    {NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter.Parameter[2]") /*Parameter.Parameter[2]*/};
                DataValue val = new DataValue(new Variant(data).Type == VariantType.Int32);

                Write(nodeIds, val).Start();
                return true;

            }

            catch (Exception e)
            {
                return false;
            }
        }

    }
}

