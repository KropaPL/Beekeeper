using Microsoft.AspNetCore.Mvc;

namespace BeekeeperApp.Controllers
{
    public class BeehiveController : Controller
    {

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
