using Microsoft.AspNetCore.Mvc;

namespace MvcHelpersAndFilters.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
