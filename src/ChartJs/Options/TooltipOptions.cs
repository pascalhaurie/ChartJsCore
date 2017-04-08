using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options
{
    public class TooltipOptions
    {
        /// <summary>
        ///     Are tooltips enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; } = true;

        /// <summary>
        ///     Sets which elements appear in the tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; } = "nearest";

        /// <summary>
        ///     	if true, the tooltip mode applies only when the mouse 
        ///         position intersects with an element. If false, the mode
        ///         will be applied at all times.
        /// </summary>
        [JsonProperty(PropertyName = "intersect")]
        public bool Intersect { get; set; } = true;

        /// <summary>
        ///     The mode for positioning the tooltip. 'average' mode will place 
        ///     the tooltip at the average position of the items displayed in the 
        ///     tooltip. 'nearest' will place the tooltip at the position of the 
        ///     element closest to the event position. New modes can be defined by 
        ///     adding functions to the Chart.Tooltip.positioners map..
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; } = "average";

        /// <summary>
        ///     Background color of the tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.8)";

        /// <summary>
        ///     Font family for tooltip title inherited from global font family.
        /// </summary>
        [JsonProperty(PropertyName = "titleFontFamily")]
        public string TitleFontFamily { get; set; } = "Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        ///     Font size for tooltip title inherited from global font size.
        /// </summary>
        [JsonProperty(PropertyName = "titleFontSize")]
        public int TitleFontSize { get; set; } = 12;

        /// <summary>
        ///     Font family for tooltip title inherited from global font family.
        /// </summary>
        [JsonProperty(PropertyName = "titleFontStyle")]
        public string TitleFontStyle { get; set; } = "bold";
    }
}