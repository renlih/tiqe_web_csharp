using Microsoft.AspNet.Mvc;

namespace tiqe_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //codigo da regra de negocio
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
