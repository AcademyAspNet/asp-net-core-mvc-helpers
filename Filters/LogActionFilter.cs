using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MvcHelpersAndFilters.Filters
{
    public class LogActionFilter : Attribute, IActionFilter
    {
        private readonly ILogger<LogActionFilter> _logger;
        private Stopwatch? _stopwatch;

        public LogActionFilter(ILogger<LogActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch?.Stop();

            string? actionName = context.ActionDescriptor.DisplayName;
            _logger.LogInformation($"Действие '{actionName}' обработано за {_stopwatch?.ElapsedMilliseconds} мсек.");
        }
    }
}
