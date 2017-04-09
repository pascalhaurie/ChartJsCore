using Newtonsoft.Json;

namespace jamiewest.ChartJs.Elements
{
    public class PointOptions
    {
        /// <summary>
        ///     Default point radius.  
        /// </summary>
        [JsonProperty(PropertyName = "radius")]
        public int Radius { get; set; } = 3;

        /// <summary>
        ///     Default point style.  
        /// </summary>
        [JsonProperty(PropertyName = "pointStyle")]
        public string PointStyle { get; set; } = "circle";

        /// <summary>
        ///     Default point fill color.  
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Default point stroke width.  
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int borderWidth { get; set; } = 1;

        /// <summary>
        ///     Default point stroke color.  
        /// </summary>
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Extra radius added to point radius for hit detection.  
        /// </summary>
        [JsonProperty(PropertyName = "hitRadius")]
        public int HitRadius { get; set; } = 1;

        /// <summary>
        ///     Default point radius when hovered.  
        /// </summary>
        [JsonProperty(PropertyName = "hoverRadius")]
        public int HoverRadius { get; set; } = 4;

        /// <summary>
        ///     Default stroke width when hovered.  
        /// </summary>
        [JsonProperty(PropertyName = "hoverBorderWidth")]
        public int HoverBorderWidth { get; set; } = 1;
    }
}