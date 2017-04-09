using Newtonsoft.Json;

namespace jamiewest.ChartJs.Elements
{
    public class RectangleOptions
    {
        /// <summary>
        ///     Default bar fill color.  
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";    

        /// <summary>
        ///     	Default bar stroke width.  
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int BorderWidth { get; set; } = 0;

        /// <summary>
        ///     Default bar stroke color.  
        /// </summary>
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; } = "rgba(0,0,0,0.1)";    

        /// <summary>
        ///     	Default skipped (excluded) border for rectangle. Can be one of bottom, left, top, right.  
        /// </summary>
        [JsonProperty(PropertyName = "borderSkipped")]
        public string BorderSkipped { get; set; } = "bottom"; 
    }
}