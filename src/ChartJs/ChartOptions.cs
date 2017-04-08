using Newtonsoft.Json;
using jamiewest.ChartJs.Options;

namespace jamiewest.ChartJs
{
    public class ChartOptions
    {
        /// <summary>
        ///     Resizes the chart canvas when its container does.
        /// </summary>
        [JsonProperty(PropertyName = "responsive")]
        public bool Responsive { get; set; } = true;

        /// <summary>
        ///     Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        [JsonProperty(PropertyName = "responsiveAnimationDuration")]
        public int ResponsiveAnimationDuration { get; set; } = 0;

        /// <summary>
        ///     Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        [JsonProperty(PropertyName = "maintainAspectRatio")]
        public bool MaintainAspectRatio { get; set; } = true;

        [JsonProperty(PropertyName = "title")]
        public TitleOptions Title { get; set; } = new TitleOptions();

        [JsonProperty(PropertyName = "legend")]
        public LegendOptions Legend { get; set; } = new LegendOptions();

        [JsonProperty(PropertyName = "tooltip")]
        public TooltipOptions Tooltip { get; set; } = new TooltipOptions();

        [JsonProperty(PropertyName = "hover")]
        public HoverOptions Hover { get; set; } = new HoverOptions();
    }
}