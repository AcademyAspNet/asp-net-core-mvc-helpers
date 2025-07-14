using Microsoft.AspNetCore.Mvc;

namespace MvcHelpersAndFilters.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Process()
        {
            return View("Index");
        }
    }
}
