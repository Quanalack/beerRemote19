
namespace Serene1.Common.Pages
{
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;

    [RoutePrefix("oldDashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        [Authorize, HttpGet, Route("~/oldDash")]
        public ActionResult Index()
        {
            var cachedModel = new DashboardPageModel()
            {
            };

            return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
        }
    }
}
