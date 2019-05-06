using BeerProduction.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Serene1.Modules.Batches
{
    [Authorize, RoutePrefix("BatchReporter"), Route("{action=index}")]
    public class BatchReporterController : Controller
    {
        private static UnitofWork _uow = new UnitofWork();

        [Authorize, HttpGet, Route("~/BatchReporter")]
        public ActionResult BatchReporter()
        {
            return View(MVC.Views.Batches.BatchReporter);
        }

        public ActionResult BatchReportViewer(int batchID)
        {
            ViewData["BatchID"] = batchID;
            return View(MVC.Views.Batches.BatchReportViewer);
        }

        public ActionResult GetAllBatches()
        {
            try
            {
                var batches = _uow.BatchReportRepos.GetAll().ToList();

                return Json(new { success = true, batches = batches, responseText = "success" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, responseText = "Getting Batches Failed" },
                    JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult GetBatch(int batchID)
        {
            try
            {
                var batch = _uow.BatchReportRepos.Find(batchID);

                return Json(new { success = true, batch = batch, responseText = "success" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, responseText = "Getting Batch Failed" },
                    JsonRequestBehavior.AllowGet);
            }
        }
    }
}