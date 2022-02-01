using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.TagHelpers
{
    public class HataTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            string @class = context.AllAttributes["class"].Value.ToString();
            output.Attributes.SetAttribute("class", @class + " alert alert-danger");
        }
    }
}
