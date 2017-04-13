using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options.Scales
{
    public class GridLineOptions
    {
        /// <summary>
        ///     
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "display")]
        public bool display { get; set; } = true;

        /// <summary>
        /// Color of the grid lines.
        /// </summary>
        [DefaultValue(new string[] { "rgba(0, 0, 0, 0.1)" })]
        [JsonProperty(PropertyName = "color")]
        public string[] Color { get; set; } = new string[] { "rgba(0, 0, 0, 0.1)" };

        /// <summary>
        /// Length and spacing of dashes.    
        /// </summary>
        [JsonProperty(PropertyName = "borderDash")]
        public int[] BorderDash { get; set; }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        [DefaultValue(0.0)]
        [JsonProperty(PropertyName = "borderDashOffset")]
        public double BorderDashOffset { get; set; } = 0.0;

        /// <summary>
        /// Stroke width of grid lines.
        /// </summary>
        [DefaultValue(new int[] { 1 })]
        [JsonProperty(PropertyName = "lineWidth")]
        public int[] LineWidth { get; set; } = new int[] { 1 };

        /// <summary>
        /// If true draw border on the edge of the chart
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "drawBorder")]
        public bool DrawBorder { get; set; } = true;

        /// <summary>
        /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "drawOnChartArea")]
        public bool DrawOnChartArea { get; set; } = true;

        /// <summary>
        /// If true, draw lines beside the ticks in the axis area beside the chart.
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "drawTicks")]
        public bool DrawTicks { get; set; } = true;

        /// <summary>
        /// Length in pixels that the grid lines will draw into the axis area.
        /// </summary>
        [DefaultValue(10)]
        [JsonProperty(PropertyName = "tickMarkLength")]
        public int TickMarkLength { get; set; } = 10;

        /// <summary>
        /// Stroke width of the grid line for the first index (index 0).
        /// </summary>
        [DefaultValue(1)]
        [JsonProperty(PropertyName = "zeroLineWidth")]
        public int ZeroLineWidth { get; set; } = 1;

        /// <summary>
        /// Stroke color of the grid line for the first index (index 0).
        /// </summary>
        [DefaultValue("rgba(0, 0, 0, 0.25)")]
        [JsonProperty(PropertyName = "zeroLineColor")]
        public string ZeroLineColor { get; set; } = "rgba(0, 0, 0, 0.25)";

        /// <summary>
        /// If true, labels are shifted to be between grid lines. This is used in the bar chart.
        /// </summary>
        [DefaultValue(false)]
        [JsonProperty(PropertyName = "offsetGridLines")]
        public bool OffsetGridLines { get; set; } = false;
    }
}
