using Newtonsoft.Json;

namespace jamiewest.ChartJs.DataSets
{
    public class BarDataSet : DataSet
    {
        /// <summary>
        ///     The data to plot as bars.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public int[] Data { get; set; }

        /// <summary>
        ///     The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        ///     The ID of the x axis to plot this dataset on.
        /// </summary>
        [JsonProperty(PropertyName = "xAxisID")]
        public string xAxisID { get; set; }

        /// <summary>
        ///     The ID of the y axis to plot this dataset on.
        /// </summary>
        [JsonProperty(PropertyName = "yAxisID")]
        public string yAxisID { get; set; }

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
        ///     Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        [JsonProperty(PropertyName = "borderSkipped")]
        public string BorderSkipped { get; set; } 

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
        ///     The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
        /// </summary>
        [JsonProperty(PropertyName = "stack")]
        public string Stack { get; set; }
    }
}