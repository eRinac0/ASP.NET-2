using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";
            return View("ActionName");
        }

        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
        [Route("Users/Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return string.Format("Пользователь: {0}, Id: {1}", user, id);
        }

        [Route("Users/Add/{user}/{password}")]
        public string ChangePass(string user, string password)
        {
            return string.Format(
                "Метод действия ChangePass() - Пользователь: <em>{0}</em>, Пароль: <em>{1}</em>",user, password);
        }
    }
}
