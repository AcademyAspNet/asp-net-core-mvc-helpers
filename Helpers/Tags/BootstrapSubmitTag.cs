using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcHelpersAndFilters.Helpers.Tags
{
    [HtmlTargetElement("submit")]
    public class BootstrapSubmitTag : TagHelper
    {
        public string Type { get; set; } = "btn-primary";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("class", $"btn {Type}");

            output.Content.Append("Отправить");
        }
    }
}
