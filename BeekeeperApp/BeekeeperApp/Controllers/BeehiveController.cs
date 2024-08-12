using Microsoft.AspNetCore.Mvc;

namespace BeekeeperApp.Controllers
{
    public class BeehiveController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
