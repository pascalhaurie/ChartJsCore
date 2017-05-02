using System.Collections.Generic;
using Newtonsoft.Json;
using jamiewest.ChartJs.Data;

namespace jamiewest.ChartJs.Data
{
    public class ChartData<TDataset>
        where TDataset : Dataset
    {
        /// <summary>
        ///     Optional parameter that is used with the category axis.
        /// </summary>
        [JsonProperty(PropertyName = "labels")]
        public string[] Labels { get; set; }

        /// <summary>
        ///     Contains data for each dataset. See the documentation for each chart type 
        ///     to determine the valid options that can be attached to the dataset.
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public List<TDataset> Datasets { get; set; } = new List<TDataset>();

        /// <summary>
        ///     Optional parameter that is used with the category axis and is used if the axis is horizontal.
        /// </summary>
        [JsonProperty(PropertyName = "xLabels")]
        public string[] xLabels { get; set; }

        /// <summary>
        ///     Optional parameter that is used with the category axis and is used if the axis is vertical.
        /// </summary>
        [JsonProperty(PropertyName = "yLabels")]
        public string[] yLabels { get; set; }
    }
}