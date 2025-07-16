using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;

namespace MvcHelpersAndFilters.Helpers.Html
{
    public static class HomeworkHtmlHelpers
    {
        public static IHtmlContent ColoredText(this IHtmlHelper htmlHelper, string text, Color color)
        {
            if (text == null)
                throw new ArgumentNullException(nameof(text));

            string style = $"color: rgba({color.R}, {color.G}, {color.B}, {color.A / 255});";

            TagBuilder span = new TagBuilder("span");
            span.Attributes.Add("style", style);
            span.InnerHtml.Append(text);

            return span;
        }
    }
}
