using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options.Elements
{
    public class ArcOptions
    {
        /// <summary>
        ///     Default fill color for arcs. Inherited from the global default.  
        /// </summary>
        [DefaultValue("rgba(0,0,0,0.1)")]
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Default stroke color for arcs.  
        /// </summary>
        [DefaultValue("#fff")]
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; } = "#fff";

        /// <summary>
        ///     Default stroke width for arcs.  
        /// </summary>
        [DefaultValue(2)]
        [JsonProperty(PropertyName = "borderWidth")]
        public int BorderWidth { get; set; } = 2;
    }
}