using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using BeerProduction.DAL;
using BeerProduction.DAL.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Extensions.Logging;
using Serene1.SubscriptionHub;
using Serenity;
using Workstation.ServiceModel.Ua;

namespace BeerProduction.OPC
{
    public sealed class Opc
    {
        private static readonly Lazy<Opc> _instance = new Lazy<Opc>(
            () => new Opc(GlobalHost.ConnectionManager.GetHubContext<SubscriptionHub>().Clients));

        public UaApp UaApp1;
        private static string Url = "opc.tcp://10.112.254.69:4840";
        private UaApplication app;

        private static UnitofWork _uow = new UnitofWork();

        public static Opc Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void Start()
        {
        }
        private IHubConnectionContext<dynamic> Clients
        {
            get;
            set;
        }
        private Opc(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;

            Connect();
        
            UaApp1 = new UaApp(app, Clients);

        }

        internal void Connect()
        {
            app = new UaApplicationBuilder()
                .SetApplicationUri($"urn:{Dns.GetHostName()}:BeerCraft")
                .ConfigureLoggerFactory(o => o.AddDebug(LogLevel.Trace))
                .AddMappedEndpoint(Url, Url, SecurityPolicyUris.None)
                .Build();
        }

        [Subscription(endpointUrl: "opc.tcp://10.112.254.69:4840", publishingInterval: -1)]
        public class UaApp : SubscriptionBase
        {
            private UaApplication App;
            private PropertyChangedEventHandler dummy = delegate { };

            private IHubConnectionContext<dynamic> Clients
            {
                get;
                set;
            }

            public UaApp(UaApplication app, IHubConnectionContext<dynamic> clients)
            {
                Clients = clients;
                {
                    App = app;
                    App.Run();
                    this.PropertyChanged += dummy; // needed to start background activities
                }
            }

            public async Task<StatusCode> ButtonClick(int data)
            {

                if (data == 1)
                {
                    if (BatchId != 0)
                    {
                        LogAll((int)BatchId);
                        var stopReasons = _uow.StopReasonRepos.Search(x => x.BatchReportId == BatchId);
                        if (stopReasons.Any())
                        {
                            var oldBatch = _uow.BatchReportRepos.Find(BatchId);

                            oldBatch.stopDateTime = DateTime.Now;
                            oldBatch.AcceptableAmount = Programproductgood;
                            oldBatch.AmountProduced = Programproductproduced;
                            oldBatch.UnacceptableAmount = Programproductbad;
                            oldBatch.stopReason = stopReasons.FirstOrDefault().Value;

                            oldBatch.OEE = oldBatch.calculateOEE();

                            _uow.BatchReportRepos.Update(oldBatch);
                        }
                        else
                        {
                            var oldBatch = _uow.BatchReportRepos.Find(BatchId);

                            oldBatch.stopDateTime = DateTime.Now;
                            oldBatch.AcceptableAmount = Programproductgood;
                            oldBatch.AmountProduced = Programproductproduced;
                            oldBatch.UnacceptableAmount = Programproductbad;
                            oldBatch.OEE = oldBatch.calculateOEE();

                            _uow.BatchReportRepos.Update(oldBatch);
                        }
                        _uow.SaveChanges();

                    }
                }

                DataValue val = new DataValue(new Variant(data));
                DataValue val2 = new DataValue(new Variant(true));

                WriteRequest writeRequest = new WriteRequest
                {
                    NodesToWrite = new WriteValue[2]
                    {
                        new WriteValue()
                        {
                            NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Command.CntrlCmd"),
                            AttributeId = AttributeIds.Value,
                            Value = val
                        },
                        new WriteValue()
                        {
                            NodeId =  NodeId.Parse("ns=6;s=::Program:Cube.Command.CmdChangeRequest"),
                            AttributeId = AttributeIds.Value,
                            Value = val2
                        },



                    },
                };
                WriteRequest request = writeRequest;





                StatusCode statusCode = (await App.GetChannelAsync(Url, new CancellationToken()).Result.WriteAsync(request)).Results[0];

                var s = statusCode.ToString();
                return statusCode;
            }

            public void LogAll(int BatchId)
            {
                var dateTime = DateTime.Now;
                Humidity humidity = new Humidity()
                {
                    DateTime = dateTime,
                    Value = ProgramDataValueRelHumidity,
                    BatchReportId = BatchId
                };
                _uow.HumidityRepos.Add(humidity);

                Temperature Temperature = new Temperature()
                {
                    DateTime = dateTime,
                    Value = ProgramDataValueTemperature,
                    BatchReportId = BatchId
                };
                _uow.TemperatureRepos.Add(Temperature);

                State State = new State()
                {
                    DateTime = dateTime,
                    Value = ProgramCubeStatusStateCurrent,
                    BatchReportId = BatchId
                };
                _uow.StateRepos.Add(State);

                MachineSpeed MachineSpeed = new MachineSpeed()
                {
                    DateTime = dateTime,
                    Value = ProgramCubeStatusCurMachSpeed,
                    BatchReportId = BatchId
                };
                _uow.MachineSpeedRepos.Add(MachineSpeed);


                _uow.SaveChanges();
            }

            public async Task<StatusCode> StartBatch(int amt, int beertype, int speed)
            {

                BatchReport batchReport = new BatchReport()
                {
                    startDateTime = DateTime.Now,
                    AmountToProduce = amt,
                    BeerType = beertype,
                    Speed = speed,
                };

                _uow.BatchReportRepos.Add(batchReport);
                _uow.SaveChanges();
                LogAll(batchReport.Id);
                DataValue amtVal = new DataValue(new Variant((float)amt));
                DataValue beertypeVal = new DataValue(new Variant((float)beertype));
                DataValue speedVal = new DataValue(new Variant((float)speed));
                DataValue BatchID = new DataValue(new Variant((float)batchReport.Id));

                WriteRequest writeRequest = new WriteRequest
                {
                    NodesToWrite = new WriteValue[4]
                    {
                        new WriteValue()
                        {
                            NodeId = NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[2].Value"),//amt
                            AttributeId = AttributeIds.Value,
                            Value = amtVal
                        },
                        new WriteValue()
                        {
                            NodeId =  NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[1].Value"),//beertypeId
                            AttributeId = AttributeIds.Value,
                            Value = beertypeVal
                        },
                        new WriteValue()
                        {
                            NodeId =  NodeId.Parse("ns=6;s=::Program:Cube.Command.MachSpeed"),//speed
                            AttributeId = AttributeIds.Value,
                            Value = speedVal
                        },

                        new WriteValue()
                        {
                            NodeId =  NodeId.Parse("ns=6;s=::Program:Cube.Command.Parameter[0].Value"),
                            AttributeId = AttributeIds.Value,
                            Value = BatchID // setId to that down here.
                        },
                    },
                };
                WriteRequest request = writeRequest;


                StatusCode statusCode = (await App.GetChannelAsync(Url, new CancellationToken()).Result.WriteAsync(request)).Results[0];

                var s = statusCode.ToString();
                return statusCode;
            }

            #region Inventory   

            /// <summary>
            /// Gets the value of ProgramInventoryBarley.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Inventory.Barley")]
            public Single ProgramInventoryBarley
            {
                get { return programInventoryBarley; }
                private set 
                { 
                    SetProperty(ref programInventoryBarley, value);
                    Clients.All.updateBarley(value);
                }
            }

            private Single programInventoryBarley;

            /// <summary>
            /// Gets the value of ProgramInventoryHops.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Inventory.Hops")]
            public Single ProgramInventoryHops
            {
                get { return programInventoryHops; }
                private set { 
                    SetProperty(ref programInventoryHops, value);
                    Clients.All.updateHops(value);
                }
            }

            private Single programInventoryHops;

            /// <summary>
            /// Gets the value of ProgramInventoryMalt.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Inventory.Malt")]
            public Single ProgramInventoryMalt
            {
                get { return programInventoryMalt; }
                private set
                {
                    SetProperty(ref programInventoryMalt, value);
                    Clients.All.updateMalt(value);
                }
            }

            private Single programInventoryMalt;

            /// <summary>
            /// Gets the value of ProgramInventoryYeast.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Inventory.Yeast")]
            public Single ProgramInventoryYeast
            {
                get { return programInventoryYeast; }
                private set
                {
                    SetProperty(ref programInventoryYeast, value);
                    Clients.All.updateYeast(value);
                }
            }

            private Single programInventoryYeast;

            /// <summary>
            /// Gets the value of ProgramInventoryWheat.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Inventory.Wheat")]
            public Single ProgramInventoryWheat
            {
                get { return programInventoryWheat; }
                private set 
                    { 
                        SetProperty(ref programInventoryWheat, value);
                        Clients.All.updateWheat(value);
                }
            }

            private Single programInventoryWheat;

            #endregion

            #region Product

            /// <summary>
            /// Gets the value of Programproductproduce_amount.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:product.produce_amount")]
            public UInt16 Programproductproduce_amount
            {
                get { return programproductproduce_amount; }
                private set
                {
                    SetProperty(ref programproductproduce_amount, value);

                    Clients.All.updateAmtToProduce(value);
                }
            }

            private UInt16 programproductproduce_amount;

            /// <summary>
            /// Gets the value of Programproductproduced.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:product.produced")]
            public UInt16 Programproductproduced
            {
                get { return programproductproduced; }
                private set {
                    SetProperty<UInt16>(ref programproductproduced, value);
                    Clients.All.updateProdProc(value);
                }
            }

            private UInt16 programproductproduced;

            /// <summary>
            /// Gets the value of Programproductgood.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:product.good")]
            public UInt16 Programproductgood
            {
                get { return programproductgood; }
                private set
                {
                    SetProperty(ref programproductgood, value);
                    
                    Clients.All.updateGoodProduced(value);
                }
            }

            private UInt16 programproductgood;

            /// <summary>
            /// Gets the value of Programproductbad.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:product.bad")]
            public UInt16 Programproductbad
            {
                get { return programproductbad; }
                private set
                {
                    SetProperty(ref programproductbad, value);
                    Clients.All.updateBadProduced(value);
                }
            }

            private UInt16 programproductbad;

            #endregion

            #region Commands

            /// <summary>
            /// Gets or sets the value of ProgramCubeCommandMachSpeed.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Command.MachSpeed")]
            public Single ProgramCubeCommandMachSpeed
            {
                get { return programCubeCommandMachSpeed; }
                set { SetProperty(ref programCubeCommandMachSpeed, value); }
            }

            private Single programCubeCommandMachSpeed;

            /// <summary>
            /// Gets or sets the value of ProgramCubeCommandCntrlCmd.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Command.CntrlCmd")]
            public Int32 ProgramCubeCommandCntrlCmd
            {
                get { return programCubeCommandCntrlCmd; }
                set { SetProperty(ref programCubeCommandCntrlCmd, value); }
            }

            private Int32 programCubeCommandCntrlCmd;

            /// <summary>
            /// Gets or sets the value of ProgramCubeCommandCmdChangeRequest.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Command.CmdChangeRequest")]
            public Boolean ProgramCubeCommandCmdChangeRequest
            {
                get { return programCubeCommandCmdChangeRequest; }
                set { SetProperty(ref programCubeCommandCmdChangeRequest, value); }
            }

            private Boolean programCubeCommandCmdChangeRequest;

            #endregion

            #region Status

        /// <summary>
        /// Gets the value of ProgramCubeStatusParameterParameter_0_Value.
        /// </summary>
        [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Status.Parameter[0].Value")]
        public Single BatchId
        {
            get { return this.programCubeStatusParameterParameter_0_Value; }
            private set
            {
                this.SetProperty(ref this.programCubeStatusParameterParameter_0_Value, value);
                Clients.All.updateBatchId(value);
                }
        }

        private Single programCubeStatusParameterParameter_0_Value;


            /// <summary>
            /// Gets the value of ProgramCubeStatusStateCurrent.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Status.StateCurrent")]
            public Int32 ProgramCubeStatusStateCurrent
            {
                get { return this.programCubeStatusStateCurrent; }
                private set
                {
                    this.SetProperty(ref this.programCubeStatusStateCurrent, value);
                    Clients.All.updateState(value);

                    if (BatchId !=0)
                    {
                    State State = new State()
                    {
                        DateTime = DateTime.Now,
                        Value = value,
                        BatchReportId = (int) BatchId
                    };

                    _uow.StateRepos.Add(State);
                    _uow.SaveChanges();
                    }
            }
            }

            private Int32 programCubeStatusStateCurrent;


            /// <summary>
            /// Gets the value of ProgramCubeStatusMachSpeed.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Status.MachSpeed")]
            public Single ProgramCubeStatusMachSpeed
            {
                get { return programCubeStatusMachSpeed; }
                private set
                {
                    SetProperty(ref programCubeStatusMachSpeed, value);
                    Clients.All.updateSpeed(value);
                    if (BatchId != 0)
                    {
                        MachineSpeed machineSpeed = new MachineSpeed()
                        {
                            DateTime = DateTime.Now,
                            Value = value,
                            BatchReportId = (int)BatchId
                        };
                        _uow.MachineSpeedRepos.Add(machineSpeed);
                        _uow.SaveChanges();
                    }
                }
            }

            private Single programCubeStatusMachSpeed;

            /// <summary>
            /// Gets the value of ProgramCubeStatusCurMachSpeed.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Status.CurMachSpeed")]
            public Single ProgramCubeStatusCurMachSpeed
            {
                get { return programCubeStatusCurMachSpeed; }
                private set
                {
                    SetProperty(ref programCubeStatusCurMachSpeed, value);
                    
                }
            }

            private Single programCubeStatusCurMachSpeed;

            #endregion

            #region Admin


            /// <summary>
            /// Gets the value of ProgramCubeAdminProdProcessedCount.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Admin.ProdProcessedCount")]
            public Int32 ProgramCubeAdminProdProcessedCount
            {
                get { return programCubeAdminProdProcessedCount; }
                private set { SetProperty(ref programCubeAdminProdProcessedCount, value);
                    Clients.All.UpdateProdProc(ProgramCubeAdminProdProcessedCount);
                }
            }

            private Int32 programCubeAdminProdProcessedCount;

            /// <summary>
            /// Gets the value of ProgramCubeAdminStopReason.
            /// </summary>
            [MonitoredItem(nodeId: "ns=6;s=::Program:Cube.Admin.StopReason.ID")]
            public Int32 ProgramCubeAdminStopReason
            {
                get { return programCubeAdminStopReason; }
                private set
                {
                    SetProperty(ref programCubeAdminStopReason, value);
                    if (BatchId != 0)
                    {
                        StopReason stopReason = new StopReason()
                        {
                            Value = value,
                            DateTime = DateTime.Now,
                            BatchReportId = (int) BatchId
                        };
                        _uow.StopReasonRepos.Add(stopReason);
                        _uow.SaveChanges();
                    }
                }
            }

            private Int32 programCubeAdminStopReason;

            #endregion

            #region Data

                    /// <summary>
        /// Gets the value of ProgramDataValueRelHumidity.
        /// </summary>
        [MonitoredItem(nodeId: "ns=6;s=::Program:Data.Value.RelHumidity")]
        public Int16 ProgramDataValueRelHumidity
        {
            get { return this.programDataValueRelHumidity; }
            private set 
            { 
                this.SetProperty(ref this.programDataValueRelHumidity, value);
                SetProperty(ref programCubeStatusCurMachSpeed, value);
                Clients.All.updateHumidity(value);
                if (BatchId != 0)
                {
                    Humidity Humidity = new Humidity()
                    {
                        DateTime = DateTime.Now,
                        Value = value,
                        BatchReportId = (int) BatchId
                    };
                    _uow.HumidityRepos.Add(Humidity);
                    _uow.SaveChanges();
                }
            }
        }

        private Int16 programDataValueRelHumidity;

        /// <summary>
        /// Gets the value of ProgramDataValueVibration.
        /// </summary>
        [MonitoredItem(nodeId: "ns=6;s=::Program:Data.Value.Vibration")]
        public Single ProgramDataValueVibration
        {
            get { return this.programDataValueVibration; }
            private set
            {
                this.SetProperty(ref this.programDataValueVibration, value);
                Clients.All.updateVibration(value);
            }
        }

        private Single programDataValueVibration;

        /// <summary>
        /// Gets the value of ProgramDataValueTemperature.
        /// </summary>
        [MonitoredItem(nodeId: "ns=6;s=::Program:Data.Value.Temperature")]
        public Single ProgramDataValueTemperature
        {
            get { return this.programDataValueTemperature; }
            private set 
            { 
                this.SetProperty(ref this.programDataValueTemperature, value);
                Clients.All.updateTemperature(value);
                if (BatchId != 0)
                {
                    Temperature Temperature = new Temperature()
                    {
                        DateTime = DateTime.Now,
                        Value = value,
                        BatchReportId = (int) BatchId
                    };
                    _uow.TemperatureRepos.Add(Temperature);
                    _uow.SaveChanges();
                }
            }
        }

        private Single programDataValueTemperature;

            #endregion

            #region Maintenance

                    /// <summary>
        /// Gets the value of ProgramMaintenanceCounter.
        /// </summary>
        [MonitoredItem(nodeId: "ns=6;s=::Program:Maintenance.Counter")]
        public UInt16 ProgramMaintenanceCounter
        {
            get { return this.programMaintenanceCounter; }
                        private set
                        {
                            this.SetProperty(ref this.programMaintenanceCounter, value);
                            Clients.All.updateMaintenance(value);
                }
        }

        private UInt16 programMaintenanceCounter;

            #endregion
        }


    }
}

