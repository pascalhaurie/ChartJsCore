using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace jamiewest.AspNetCore.ChartJs.TagHelpers
{
    public class BodyTagHelper : TagHelper
    {
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (((Dictionary<string, object>)ViewContext.ViewData["Urls"]).Count > 0)
            {
                var sb = new StringBuilder();

                foreach (var keyValuePair in ((Dictionary<string, object>)ViewContext.ViewData["Urls"]))
                {
                    sb.AppendLine();
                    sb.AppendLine("<script>");
                    sb.AppendLine("    $.getJSON(\"" + keyValuePair.Key + "\", function(config){");
                    sb.AppendLine("        var chart = new Chart(document.getElementById(\"" + keyValuePair.Value + "\"), config);");
                    sb.AppendLine("    });");
                    sb.AppendLine("</script>");
                }

                output.PostContent.AppendHtml(sb.ToString());
            }
        }
    }
}
