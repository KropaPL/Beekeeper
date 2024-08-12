using Microsoft.AspNetCore.Mvc;

namespace BeekeeperApp.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [Route("/[action]")]
        [Route("/")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
