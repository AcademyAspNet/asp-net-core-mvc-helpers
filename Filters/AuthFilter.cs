using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace MvcHelpersAndFilters.Filters
{
    public class AuthFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("UserName") == null)
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
        }
    }
}
