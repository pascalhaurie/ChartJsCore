using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options
{
    public class LayoutOptions
    {
        /// <summary>
        ///     The padding to add inside the chart. If this value is a number,
        ///     it is applied to all sides of the chart (left, top, right, bottom).
        ///     If this value is an object, the left property defines the left padding. 
        ///     Similarly the right, top, and bottom properties can also be specified.
        /// </summary>
        [JsonProperty(PropertyName = "padding")]
        public int Padding { get; set; } = 0;
    }
}