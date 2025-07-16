using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcHelpersAndFilters.Helpers.Tags
{
    [HtmlTargetElement("bootstrap-button")]
    public class BootstrapButtonTag : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("class", "btn btn-primary");
            output.Attributes.Add("type", "button");
        }
    }
}
