using System.Web.Mvc;

namespace Mvc5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Test(string text = null)
        {
            ViewBag.Param = text;
            ViewBag.Dict = Request.Params;
            return View();
        }
    }
}