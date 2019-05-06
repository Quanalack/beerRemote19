using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using BeerProduction.OPC;
using Workstation.ServiceModel.Ua;


namespace Serene1.SubscriptionHub
{
    [HubName("SubscriptionTicker")]
    public class SubscriptionHub : Hub
    {
        //private Opc _opc;
        
        //public SubscriptionHub() :
        //    this(Opc.Instance)
        //{
        //}

        public SubscriptionHub(/*Opc opc*/)
        {
            //_opc = opc;
        }
    }
}