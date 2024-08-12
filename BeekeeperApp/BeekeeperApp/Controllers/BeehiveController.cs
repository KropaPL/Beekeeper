using Microsoft.AspNetCore.Mvc;

namespace BeekeeperApp.Controllers
{
    [Route("[controller]")]
    public class BeehiveController : Controller
    {
        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
