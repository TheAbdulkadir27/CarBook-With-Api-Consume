using Microsoft.AspNetCore.Mvc;
namespace CarBook.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.V1 = "Hizmetler";
            ViewBag.V2 = "Hizmetlerimiz";
            return View();
        }
    }
}
