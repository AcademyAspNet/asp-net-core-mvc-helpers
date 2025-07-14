using Microsoft.AspNetCore.Mvc;

namespace MvcHelpersAndFilters.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
