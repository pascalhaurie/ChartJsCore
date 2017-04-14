using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options.Scales
{
    public class LabelOptions
    {
        /// <summary>
        ///     
        /// </summary>
        [DefaultValue(false)]
        [JsonProperty(PropertyName = "display")]
        public bool Display { get; set; } = false;

        /// <summary>
        /// The text for the title. (i.e. "# of People", "Response Choices")
        /// </summary>
        [DefaultValue("")]
        [JsonProperty(PropertyName = "labelString")]
        public string LabelString { get; set; } = "";

        /// <summary>
        /// Font color for the scale title.
        /// </summary>
        [DefaultValue("#666")]
        [JsonProperty(PropertyName = "fontColor")]
        public string FontColor { get; set; } = "#666";

        /// <summary>
        /// Font family for the scale title, follows CSS font-family options.
        /// </summary>
        [DefaultValue("'Helvetica Neue', 'Helvetica', 'Arial', sans-serif")]
        [JsonProperty(PropertyName = "fontFamily")]
        public string FontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        /// Font size for the scale title.
        /// </summary>
        [DefaultValue(12)]
        [JsonProperty(PropertyName = "fontSize")]
        public int FontSize { get; set; } = 12;

        /// <summary>
        /// Font style for the scale title, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        [DefaultValue("normal")]
        [JsonProperty(PropertyName = "fontStyle")]
        public string FontStyle { get; set; } = "normal";
    }
}
