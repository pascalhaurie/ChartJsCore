using Newtonsoft.Json;

namespace jamiewest.ChartJs.Elements
{
    public class LineOptions
    {
        /// <summary>
        ///     Default bezier curve tension. Set to 0 for no bezier curves.  
        /// </summary>
        [JsonProperty(PropertyName = "tension")]
        public double Tension { get; set; } = .4;

        /// <summary>
        ///     Default line fill color.  
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string BackgroundColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Default line stroke width.  
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int BorderWidth { get; set; } = 3;

        /// <summary>
        ///     Default line stroke color.  
        /// </summary>
        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; } = "rgba(0,0,0,0.1)";

        /// <summary>
        ///     Default line cap style.  
        /// </summary>
        [JsonProperty(PropertyName = "borderCapStyle")]
        public string BorderCapStyle { get; set; } = "butt";

        /// <summary>
        ///     Default line dash.  
        /// </summary>
        [JsonProperty(PropertyName = "borderDash")]
        public string[] BorderDash { get; set; }

        /// <summary>
        ///     Default line dash offset. 
        /// </summary>
        [JsonProperty(PropertyName = "borderDashOffset")]
        public int BorderDashOffset { get; set; } = 0;

        /// <summary>
        ///     Default line join style. 
        /// </summary>
        [JsonProperty(PropertyName = "borderJoinStyle")]
        public string BorderJoinStyle { get; set; } = "miter";

        /// <summary>
        ///     If true, bezier control points are kept inside the chart. If false, no restriction is enforced. 
        /// </summary>
        [JsonProperty(PropertyName = "capBezierPoints")]
        public bool CapBezierPoints { get; set; } = true;

        /// <summary>
        ///     If true, the fill is assumed to be to zero. String values are 'zero', 'top', and 'bottom'
        ///     to fill to different locations. If false, no fill is added. 
        /// </summary>
        [JsonProperty(PropertyName = "fill")]
        public bool Fill { get; set; } = true;

        /// <summary>
        ///     If true, the line is shown as a stepped line and 'tension' will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "stepped")]
        public bool Stepped { get; set; } = false;
    }
}