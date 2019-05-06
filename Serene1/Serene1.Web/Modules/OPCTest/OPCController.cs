using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeerProduction.OPC;
using Workstation.ServiceModel.Ua;

namespace Serene1.Modules.OPCTest
{
    public class OPCController : Controller 
    {
        // GET: OPC
        public ActionResult Index()
        {
            return View();
        }

    }
}