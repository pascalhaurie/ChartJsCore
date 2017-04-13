using Newtonsoft.Json;

namespace jamiewest.ChartJs.Datasets
{
    public class PieDataset : Dataset
    {
        /// <summary>
        ///     The data to plot as arcs.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public int[] Data { get; set; }

        /// <summary>
        ///     The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

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
    }
}