using Microsoft.AspNetCore.Mvc;

namespace Announcer.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
