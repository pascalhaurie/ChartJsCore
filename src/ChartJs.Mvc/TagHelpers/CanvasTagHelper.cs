using System.Text;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace jamiewest.ChartJs.Mvc.TagHelpers
{
    [HtmlTargetElement("canvas")] 
    public class CanvasTagHelper : TagHelper
    {
        public string Url { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("<script>");
            sb.AppendLine("    $.getJSON(\"" + Url + "\", function(data){");
            sb.AppendLine("        var chart = new Chart(document.getElementById(\"" + output.Attributes["Id"].Value + "\"), data);");
            sb.AppendLine("    });");
            sb.AppendLine("</script>");
            
            output.PostElement.AppendHtml(sb.ToString());
        }
    }
}