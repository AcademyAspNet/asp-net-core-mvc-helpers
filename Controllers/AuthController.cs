using Microsoft.AspNetCore.Mvc;
using MvcHelpersAndFilters.Filters;
using MvcHelpersAndFilters.Models.Views;

namespace MvcHelpersAndFilters.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new AuthViewModel());
        }

        [HttpPost]
        public IActionResult Process(AuthViewModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);

            HttpContext.Session.SetString("UserName", model.UserName!);

            return View("Result", model);
        }

        [HttpPost]
        public IActionResult Delete()
        {
            return Content("Deleted!");
        }
    }
}
