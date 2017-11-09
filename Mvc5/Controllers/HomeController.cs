using System.Web.Mvc;
using System.Linq;

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

        [HttpGet]
        [ActionName("Test")]
        public ActionResult TestIndex(string text = null)
        {
            return Test(text);
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Test(string text = null)
        {
            if (Request.AcceptTypes != null)
                if (Request.AcceptTypes.Contains("application/json"))
                {
                    return Json(new
                    {
                        Param = text,
                        Dict = Request.Params
                    }, JsonRequestBehavior.AllowGet);
                }

            ViewBag.Param = text;
            ViewBag.Dict = Request.Params;
            return View();
        }
    }
}