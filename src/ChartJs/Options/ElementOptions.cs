using Newtonsoft.Json;
using jamiewest.ChartJs.Elements;

namespace jamiewest.ChartJs.Options
{
    public class ElementOptions
    {
        /// <summary>
        ///     Arcs are used in the polar area, doughnut and pie charts. 
        /// </summary>
        [JsonProperty(PropertyName = "arc")]
        public ArcOptions Arc { get; set; } = new ArcOptions();

        /// <summary>
        ///     Line elements are used to represent the line in a line chart.  
        /// </summary>
        [JsonProperty(PropertyName = "lines")]
        public LineOptions Lines { get; set; } = new LineOptions();

        /// <summary>
        ///     Point elements are used to represent the points in a line chart or a bubble chart.  
        /// </summary>
        [JsonProperty(PropertyName = "points")]
        public PointOptions Points { get; set; } = new PointOptions();

        /// <summary>
        ///     Rectangle elements are used to represent the bars in a bar chart. .  
        /// </summary>
        [JsonProperty(PropertyName = "rectangles")]
        public RectangleOptions Rectangles { get; set; } = new RectangleOptions();
    }
}
