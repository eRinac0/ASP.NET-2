using System.Web.Mvc;

namespace UrlsAndRoutes.AdditionalController
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "AdditionalController.Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
        public ViewResult MyActionMethod()
        {
            string myActionUrl = Url.Action("Index", new { id = "MyID" });
            string myRouteUrl = Url.RouteUrl(new { controller = "Home", action = "Index" });

            // делать что-нибудь с URL

            return View();
        }
    }
}