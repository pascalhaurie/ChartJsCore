using Newtonsoft.Json;

namespace jamiewest.ChartJs.Elements
{
    public class Arc
    {
        /// <summary>
        ///     Default fill color for arcs. Inherited from the global default.  
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Default stroke color for arcs.  
        /// </summary>
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; } = "#fff";

        /// <summary>
        ///     Default stroke width for arcs.  
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int BorderWidth { get; set; } = 2;
    }
}