using Newtonsoft.Json;

namespace jamiewest.ChartJs.DataSets
{
    public class RadarDataSet : DataSet
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
        ///     If true, fill the area under the line.
        /// </summary>
        [JsonProperty(PropertyName = "fill")]
        public bool Fill { get; set; }

        /// <summary>
        ///     Bezier curve tension of the line. Set to 0 to draw straightlines. 
        ///     Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        [JsonProperty(PropertyName = "lineTension")]
        public int LineTension { get; set; }

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
        ///     Cap style of the line.
        /// </summary>
        [JsonProperty(PropertyName = "borderCapStyle")]
        public int BorderCapStyle { get; set; }  

        /// <summary>
        ///     Length and spacing of dashes.
        /// </summary>
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
        [JsonProperty(PropertyName = "pointBorderColor")]
        public string[] PointBorderColor { get; set; } 

        /// <summary>
        ///     The fill color for points.
        /// </summary>
        [JsonProperty(PropertyName = "pointBackgroundColor")]
        public string[] PointBackgroundColor { get; set; } 

        /// <summary>
        ///     The width of the point border in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "pointBorderWidth")]
        public int PointBorderWidth { get; set; } 

        /// <summary>
        ///     The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        [JsonProperty(PropertyName = "pointRadius")]
        public int PointRadius { get; set; } 

        /// <summary>
        ///     The radius of the point when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "pointHoverRadius")]
        public int PointHoverRadius { get; set; } 

        /// <summary>
        ///     The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        [JsonProperty(PropertyName = "pointHitRadius")]
        public int PointHitRadius { get; set; } 

        /// <summary>
        ///     Point background color when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "pointHoverBackgroundColor")]
        public string[] PointHoverBackgroundColor { get; set; } 

        /// <summary>
        ///     Point border color when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "pointHoverBorderColor")]
        public string[] PointHoverBorderColor { get; set; } 

        /// <summary>
        ///     Border width of point when hovered.
        /// </summary>
        [JsonProperty(PropertyName = "pointHoverBorderWidth")]
        public int PointHoverBorderWidth { get; set; } 

        /// <summary>
        ///     The style of point. Options include 'circle', 'triangle', 'rect', 'rectRounded', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'.
        /// </summary>
        [JsonProperty(PropertyName = "pointStyle")]
        public string PointStyle { get; set; } 
    }
}