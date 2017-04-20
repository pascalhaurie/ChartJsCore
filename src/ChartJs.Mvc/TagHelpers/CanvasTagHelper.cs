using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace jamiewest.ChartJs.Mvc.TagHelpers
{
    [HtmlTargetElement("canvas")]
    public class CanvasTagHelper : TagHelper
    {
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string Url { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            object Urls;
            if (ViewContext.ViewData.TryGetValue("Urls", out Urls))
            {
                ((Dictionary<string, object>)Urls).Add(Url, output.Attributes["Id"].Value);
            }
            else
            {
                Dictionary<string, object> Urls1 = new Dictionary<string, object>();

                Urls1.Add(Url, output.Attributes["Id"].Value);

                ViewContext.ViewData.Add("Urls", Urls1); 
            }
        }
    }
}