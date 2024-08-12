using Microsoft.AspNetCore.Mvc;

namespace BeekeeperApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
