using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options.Scales
{
    public class CommonOptions
    {
        /// <summary>
        ///     Type of scale being employed. Custom scales can be created and registered with a string key. Options: "category", "linear", "logarithmic", "time", "radialLinear"
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// If true, show the scale including gridlines, ticks, and labels. Overrides gridLines.display, scaleLabel.display, and ticks.display.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public bool Display { get; set; } = true;

        /// <summary>
        ///     Position of the scale. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        [DefaultValue("left")]
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; } = "left";

        /// <summary>
        ///     The ID is used to link datasets and scale axes together. The properties datasets.xAxisID or datasets.yAxisID have to match the scale properties scales.xAxes.id or scales.yAxes.id. This is especially needed if multi-axes charts are used.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Callback called before the update process starts. Passed a single argument, the scale instance.
        /// </summary>
        [JsonProperty(PropertyName = "beforeUpdate")]
        public string BeforeUpdate { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "beforeSetDimensions")]
        public string BeforeSetDimensions { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterSetDimensions")]
        public string AfterSetDimensions { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "beforeDataLimits")]
        public string BeforeDataLimits { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterDataLimits")]
        public string AfterDataLimits { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "beforeBuildTicks")]
        public string BeforeBuildTicks { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterBuildTicks")]
        public string AfterBuildTicks { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "beforeTickToLabelConversion")]
        public string BeforeTickToLabelConversion { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterTickToLabelConversion")]
        public string AfterTickToLabelConversion { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "beforeCalculateTickRotation")]
        public string BeforeCalculateTickRotation { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterCalculateTickRotation")]
        public string AfterCalculateTickRotation { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "beforeFit")]
        public string BeforeFit { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterFit")]
        public string AfterFit { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "afterUpdate")]
        public string AfterUpdate { get; set; }

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "gridLines")]
        public GridLineOptions GridLines { get; set; } = new GridLineOptions();

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "scaleLabel")]
        public LabelOptions ScaleLabel { get; set; } = new LabelOptions();

        /// <summary>
        ///     
        /// </summary>
        [JsonProperty(PropertyName = "ticks")]
        public TickOptions Ticks { get; set; } = new TickOptions();
    }
}