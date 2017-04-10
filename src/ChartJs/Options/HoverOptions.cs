using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options
{
    public class HoverOptions
    {
        /// <summary>
        ///     Sets which elements appear in the tooltip.  
        /// </summary>
        [DefaultValue("nearest")]
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; } = "nearest";

        /// <summary>
        ///     If true, the hover mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "intersect")]
        public bool intersect { get; set; } = true;

        /// <summary>
        ///     Duration in milliseconds it takes to animate hover style changes.
        /// </summary>
        [DefaultValue(400)]
        [JsonProperty(PropertyName = "animationDuration")]
        public int AnimationDuration { get; set; } = 400;

        /// <summary>
        ///     Called when any of the events fire. Called in the context of the 
        ///     chart and passed the event and an array of active elements (bars, points, etc).
        /// </summary>
        [JsonProperty(PropertyName = "onHover")]
        public string OnHover { get; set; }
    }
}