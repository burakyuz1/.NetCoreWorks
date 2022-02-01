using Microsoft.AspNetCore.Razor.TagHelpers;
using SehirBolgeCustomTagHelper.Models;
using System.Collections.Generic;

namespace SehirBolgeCustomTagHelper.TagHelpers
{
    //[HtmlTargetElement(Attributes = "SehirList")]
    public class SehirlerTagHelper : TagHelper
    {
        public List<Sehir> SehirItems { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            var sehirListesi = (dynamic)context.AllAttributes[0].Value;
            foreach (var sehir in sehirListesi)
            {
                output.Content.AppendHtml($"<li>[{sehir.Id.ToString("00")}] {sehir.SehirAd} ({sehir.Nufus.ToString("n0")})");
            }
        }
    }
}
