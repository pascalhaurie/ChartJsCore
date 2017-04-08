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
        
        /// <summary>
        ///     Font color for tooltip title.
        /// </summary>
        [JsonProperty(PropertyName = "titleFontColor")]
        public string TitleFontColor { get; set; } = "#fff";

        /// <summary>
        ///     Spacing to add to top and bottom of each title line.
        /// </summary>
        [JsonProperty(PropertyName = "titleSpacing")]
        public int TitleSpacing { get; set; } = 2;

        /// <summary>
        ///     Margin to add on bottom of title section.
        /// </summary>
        [JsonProperty(PropertyName = "titleMarginBottom")]
        public int TitleMarginBottom { get; set; } = 6;

        /// <summary>
        ///     Font family for tooltip items inherited from global font family.
        /// </summary>
        [JsonProperty(PropertyName = "bodyFontFamily")]
        public string BodyFontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        ///     Font size for tooltip items inherited from global font size.
        /// </summary>
        [JsonProperty(PropertyName = "bodyFontSize")]
        public int BodyFontSize { get; set; } = 12;

        /// <summary>
        ///     N/a
        /// </summary>
        [JsonProperty(PropertyName = "bodyFontStyle")]
        public string BodyFontStyle { get; set; } = "normal";

        /// <summary>
        ///     Font color for tooltip items.
        /// </summary>
        [JsonProperty(PropertyName = "bodyFontColor")]
        public string BodyFontColor { get; set; } = "#fff";

        /// <summary>
        ///     Spacing to add to top and bottom of each tooltip item.
        /// </summary>
        [JsonProperty(PropertyName = "bodySpacing")]
        public int BodySpacing { get; set; } = 2;
        
        /// <summary>
        ///     Font family for tooltip footer inherited from global font family..
        /// </summary>
        [JsonProperty(PropertyName = "footerFontFamily")]
        public string FooterFontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        ///     Font size for tooltip footer inherited from global font size.
        /// </summary>
        [JsonProperty(PropertyName = "footerFontSize")]
        public int FooterFontSize { get; set; } = 12;

        /// <summary>
        ///     Font style for tooltip footer.
        /// </summary>
        [JsonProperty(PropertyName = "footerFontStyle")]
        public string FooterFontStyle { get; set; } = "bold";

        /// <summary>
        ///     Font color for tooltip footer.
        /// </summary>
        [JsonProperty(PropertyName = "footerFontColor")]
        public string FooterFontColor { get; set; } = "#fff";

        /// <summary>
        ///     Spacing to add to top and bottom of each footer line.
        /// </summary>
        [JsonProperty(PropertyName = "footerSpacing")]
        public int FooterSpacing { get; set; } = 2;

        /// <summary>
        ///     Margin to add before drawing the footer.
        /// </summary>
        [JsonProperty(PropertyName = "footerMarginTop")]
        public int FooterMarginTop { get; set; } = 6;

        /// <summary>
        ///     Padding to add on left and right of tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "xPadding")]
        public int xPadding { get; set; } = 6;

        /// <summary>
        ///     Padding to add on top and bottom of tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "yPadding")]
        public int yPadding { get; set; } = 6;

        /// <summary>
        ///     Size, in px, of the tooltip arrow.
        /// </summary>
        [JsonProperty(PropertyName = "caretSize")]
        public int CaretSize { get; set; } = 5;

        /// <summary>
        ///     Radius of tooltip corner curves.
        /// </summary>
        [JsonProperty(PropertyName = "cornerRadius")]
        public int CornerRadius { get; set; } = 6;

        /// <summary>
        ///     Color to draw behind the colored boxes when multiple items are in the tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "multiKeyBackground")]
        public string MultiKeyBackground { get; set; } = "#fff";

        /// <summary>
        ///     if true, color boxes are shown in the tooltip.
        /// </summary>
        [JsonProperty(PropertyName = "displayColors")]
        public bool DisplayColors { get; set; } = true;
    }
}