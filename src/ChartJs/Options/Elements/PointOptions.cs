using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options.Elements
{
    public class PointOptions
    {
        /// <summary>
        ///     Default point radius.  
        /// </summary>
        [DefaultValue(3)]
        [JsonProperty(PropertyName = "radius")]
        public int Radius { get; set; } = 3;

        /// <summary>
        ///     Default point style.  
        /// </summary>
        [DefaultValue("circle")]
        [JsonProperty(PropertyName = "pointStyle")]
        public string PointStyle { get; set; } = "circle";

        /// <summary>
        ///     Default point fill color.  
        /// </summary>
        [DefaultValue("rgba(0,0,0,0.1)")]
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Default point stroke width.  
        /// </summary>
        [DefaultValue(1)]
        [JsonProperty(PropertyName = "borderWidth")]
        public int borderWidth { get; set; } = 1;

        /// <summary>
        ///     Default point stroke color.  
        /// </summary>
        [DefaultValue("rgba(0,0,0,0.1)")]
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Extra radius added to point radius for hit detection.  
        /// </summary>
        [DefaultValue(1)]
        [JsonProperty(PropertyName = "hitRadius")]
        public int HitRadius { get; set; } = 1;

        /// <summary>
        ///     Default point radius when hovered.  
        /// </summary>
        [DefaultValue(4)]
        [JsonProperty(PropertyName = "hoverRadius")]
        public int HoverRadius { get; set; } = 4;

        /// <summary>
        ///     Default stroke width when hovered.  
        /// </summary>
        [DefaultValue(1)]
        [JsonProperty(PropertyName = "hoverBorderWidth")]
        public int HoverBorderWidth { get; set; } = 1;
    }
}