using Newtonsoft.Json;

namespace jamiewest.ChartJs.Data
{
    public class Dataset
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
    }
}