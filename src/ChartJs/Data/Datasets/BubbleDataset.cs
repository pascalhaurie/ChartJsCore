using Newtonsoft.Json;

namespace jamiewest.ChartJs.Data
{
    public class BubbleDataset : Dataset
    {
        /// <summary>
        ///     The fill color under the line.
        /// </summary>
        [JsonProperty(PropertyName = "backgroundColor")]
        public string[] BackgroundColor { get; set; }

        /// <summary>
        ///     The color of the line.
        /// </summary>
        [JsonProperty(PropertyName = "borderColor")]
        public string[] BorderColor { get; set; }

        /// <summary>
        ///     The width of the line in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int BorderWidth { get; set; }  

        /// <summary>
        ///     Bar background color when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "hoverBackgroundColor")]
        public string[] HoverBackgroundColor { get; set; } 

        /// <summary>
        ///     Bar border color when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "hoverBorderColor")]
        public string[] HoverBorderColor { get; set; }

        /// <summary>
        ///     Border width of bar when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "hoverBorderWidth")]
        public int HoverBorderWidth { get; set; }

        /// <summary>
        ///     Additional radius to add to data radius on hover.
        /// </summary>
        [JsonProperty(PropertyName = "hoverRadius")]
        public int HoverRadius { get; set; }
    }
}