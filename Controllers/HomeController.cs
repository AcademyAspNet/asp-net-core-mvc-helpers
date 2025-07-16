using Microsoft.AspNetCore.Mvc;
using MvcHelpersAndFilters.Filters;

namespace MvcHelpersAndFilters.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AuthFilter]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
