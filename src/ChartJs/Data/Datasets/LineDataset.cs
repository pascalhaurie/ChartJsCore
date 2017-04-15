using jamiewest.ChartJs.Internal.ContractResolvers;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Datasets
{
    public class LineDataset : Dataset
    {
        /// <summary>
        ///     The data to plot in a line.
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
        ///     If true, fill the area under the line.
        /// </summary>
        [JsonProperty(PropertyName = "fill", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Fill { get; set; }

        /// <summary>
        ///     Algorithm used to interpolate a smooth curve from the discrete data points. 
        ///     Options are 'default' and 'monotone'. The 'default' algorithm uses a custom 
        ///     weighted cubic interpolation, which produces pleasant curves for all types of 
        ///     datasets. The 'monotone' algorithm is more suited to y = f(x) datasets : it 
        ///     preserves monotonicity (or piecewise monotonicity) of the dataset being interpolated, 
        ///     and ensures local extremums (if any) stay at input data points. If left untouched 
        ///     (undefined), the global options.elements.line.cubicInterpolationMode property is used.
        /// </summary>
        [JsonProperty(PropertyName = "cubicInterpolationMode")]
        public string CubicInterpolationMode { get; set; }

        /// <summary>
        ///      Bezier curve tension of the line. Set to 0 to draw straightlines. This option 
        ///      is ignored if monotone cubic interpolation is used. Note This was renamed from 
        ///      'tension' but the old name still works. 
        /// </summary>
        [JsonProperty(PropertyName = "lineTension")]
        public int LineTension { get; set; }

        /// <summary>
        ///     The fill color under the line.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty(PropertyName = "backgroundColor")]
        public string[] BackgroundColor { get; set; }

        /// <summary>
        ///     The color of the line.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty(PropertyName = "borderColor")]
        public string[] BorderColor { get; set; }

        /// <summary>
        ///     The width of the line in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "borderWidth")]
        public int BorderWidth { get; set; }        

        /// <summary>
        ///     Cap style of the line.
        /// </summary>
        [JsonProperty(PropertyName = "borderCapStyle")]
        public string BorderCapStyle { get; set; }

        /// <summary>
        ///     Length and spacing of dashes.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "borderDash")]
        public int[] BorderDash { get; set; }

        /// <summary>
        ///     Offset for line dashes.
        /// </summary>
        [JsonProperty(PropertyName = "borderDashOffset")]
        public int BorderDashOffset { get; set; }

        /// <summary>
        ///     Line joint style.
        /// </summary>
        [JsonProperty(PropertyName = "borderJoinStyle")]
        public string BorderJoinStyle { get; set; }

        /// <summary>
        ///     The border color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty(PropertyName = "pointBorderColor")]
        public string[] PointBorderColor { get; set; }

        /// <summary>
        ///     The fill color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty(PropertyName = "pointBackgroundColor")]
        public string[] PointBackgroundColor { get; set; }

        /// <summary>
        ///     The width of the point border in pixels.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "pointBorderWidth")]
        public int[] PointBorderWidth { get; set; }

        /// <summary>
        ///     The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "pointRadius")]
        public int[] PointRadius { get; set; }

        /// <summary>
        ///     The radius of the point when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "pointHoverRadius")]
        public int[] PointHoverRadius { get; set; }

        /// <summary>
        ///     The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "pointHitRadius")]
        public int[] PointHitRadius { get; set; }

        /// <summary>
        ///      Point background color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty(PropertyName = "pointHoverBackgroundColor")]
        public string[] PointHoverBackgroundColor { get; set; }

        /// <summary>
        ///      Point border color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty(PropertyName = "pointHoverBorderColor")]
        public string[] PointHoverBorderColor { get; set; }

        /// <summary>
        ///      Border width of point when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "pointHoverBorderWidth")]
        public int[] pointHoverBorderWidth { get; set; }

        /// <summary>
        ///      The style of point. Options are 'circle', 'triangle', 'rect', 'rectRounded', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty(PropertyName = "pointStyle")]
        public string[] PointStyle { get; set; }

        /// <summary>
        ///      If false, the line is not drawn for this dataset.
        /// </summary>
        [JsonProperty(PropertyName = "showLine")]
        public bool ShowLine { get; set; }

        /// <summary>
        ///      If true, lines will be drawn between points with no or null data.
        /// </summary>
        [JsonProperty(PropertyName = "spanGaps")]
        public bool SpanGaps { get; set; }

        /// <summary>
        ///      If true, the line is shown as a stepped line and 'lineTension' will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "steppedLine")]
        public bool SteppedLine { get; set; }
    }
}
