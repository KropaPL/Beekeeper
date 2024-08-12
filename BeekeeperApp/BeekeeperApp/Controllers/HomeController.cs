using Microsoft.AspNetCore.Mvc;

namespace BeekeeperApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
