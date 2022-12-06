using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI.Controllers
{
    public class SuperPowerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
