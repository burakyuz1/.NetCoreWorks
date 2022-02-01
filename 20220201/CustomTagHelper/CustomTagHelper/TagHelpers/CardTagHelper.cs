using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace CustomTagHelper.TagHelpers
{
    public class CardTagHelper : TagHelper
    {
        public string Baslik { get; set; }
        public string Baslik2 { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var mevcutIcerik = await output.GetChildContentAsync();
            output.TagName = "div";

            output.Attributes.SetAttribute("class", "card text-white bg-dark mb-3");
            output.Attributes.SetAttribute("style", "max-width: 18rem;");

            output.Content.AppendHtml($"<div class=\"card-header\">{Baslik}</div>");
            output.Content.AppendHtml($"<div class=\"card-body\"> " +
                $"<h5 class=\"card-title\">{Baslik2}</h5>" +
                $"<p class=\"card-text\">{mevcutIcerik.GetContent()}</p>" +
                $"</div>");
        }
    }
}
