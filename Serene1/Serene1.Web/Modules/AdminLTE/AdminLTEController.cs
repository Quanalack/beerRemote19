
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BeerProduction.DAL;
using BeerProduction.OPC;

namespace Serene1.AdminLTE
{
    using Serenity.Web;
    using System.Web.Mvc;
    using BeerProduction.OPC;

    [Authorize, RoutePrefix("Dashboard"), Route("{action=index}")]
    public class AdminLTEController : Controller
    {
        private UnitofWork _uow = new UnitofWork();

        [Authorize, HttpGet, Route("~/")]
        public ActionResult DashboardV2()
        {
            return View(MVC.Views.AdminLTE.DashboardV2);
        }

        public ActionResult Widgets()
        {
            return View(MVC.Views.AdminLTE.Widgets);
        }

        public ActionResult Calendar()
        {
            return View(MVC.Views.AdminLTE.Calendar);
        }

        public ActionResult GetDbTemps()
        {
            try
            {
                return Json(new { success = true,  responseText = "success" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, responseText = "Getting TimeRegs Failed" },
                    JsonRequestBehavior.AllowGet);
            }

        }
        public async Task<ActionResult> StartNewBatch(int amt, int beertypeId, int speed)
        {
            var setBatchStatusCode = await Opc.Instance.UaApp1.StartBatch(amt, beertypeId, speed);

            if (setBatchStatusCode.ToString() == "0x00000000")
            {
               var buttonStatusCode = await Opc.Instance.UaApp1.ButtonClick(2);

                if (buttonStatusCode.ToString() == "0x00000000")
                {
                   return Json(new { success = true, responseText = "success" },
                            JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, responseText = buttonStatusCode}, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { success = false, responseText = setBatchStatusCode },
                    JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetAllStats()
        {
            var opc = Opc.Instance.UaApp1;

            try
            {
                
                return Json(new { success = true,
                        batchId = opc.BatchId,
                        barley = opc.ProgramInventoryBarley,
                        hops = opc.ProgramInventoryHops,
                        malt = opc.ProgramInventoryMalt,
                        yeast = opc.ProgramInventoryYeast,
                        wheat = opc.ProgramInventoryWheat,
                        prodProcAmt = opc.Programproductproduce_amount,
                        prodProc = opc.Programproductproduced,
                        prodProcG = opc.Programproductgood,
                        prodProcB = opc.Programproductbad,
                        currentState = opc.ProgramCubeStatusStateCurrent,
                        machSpeed = opc.ProgramCubeStatusMachSpeed,
                        humidity = opc.ProgramDataValueRelHumidity,
                        vibra = opc.ProgramDataValueVibration,
                        temp = opc.ProgramDataValueTemperature,
                        maintenance = opc.ProgramMaintenanceCounter,
                        responseText = "success" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json(new { success = false, responseText = "Getting TimeRegs Failed" },
                    JsonRequestBehavior.AllowGet);
            }

        }


        public async Task<ActionResult> ActionBtnClick(int data)
        {
            try
            {
                await Opc.Instance.UaApp1.ButtonClick(data);
                return Json(new { success = true, responseText = "success" },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception )
            {
                return Json(new { success = false, responseText = "Getting TimeRegs Failed" },
                    JsonRequestBehavior.AllowGet);
            }
        }

    }
 }
