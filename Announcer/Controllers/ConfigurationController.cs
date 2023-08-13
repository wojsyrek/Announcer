using Microsoft.AspNetCore.Mvc;

namespace Announcer.Controllers
{
    public class ConfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
