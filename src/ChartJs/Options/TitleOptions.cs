using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options
{
    public class TitleOptions
    {
        /// <summary>
        ///     Display the title block.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public bool Display { get; set; } = true;

        /// <summary>
        ///     Position of the title. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; } = "top";

        /// <summary>
        ///     Marks that this box should take the full width of the canvas (pushing down other boxes).
        /// </summary>
        [JsonProperty(PropertyName = "fullWidth")]
        public bool FullWidth { get; set; } = true;

        /// <summary>
        ///     Font size inherited from global configuration.
        /// </summary>
        [JsonProperty(PropertyName = "fontSize")]
        public int FontSize { get; set; } = 12;

        /// <summary>
        ///     Font family inherited from global configuration.
        /// </summary>
        [JsonProperty(PropertyName = "fontFamily")]
        public string FontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        ///     Font color inherited from global configuration.
        /// </summary>
        [JsonProperty(PropertyName = "fontColor")]
        public string[] FontColor { get; set; } = new string[] { "rgba(102,102,102,1)" };

        /// <summary>
        ///     Font styling of the title.
        /// </summary>
        [JsonProperty(PropertyName = "fontStyle")]
        public string FontStyle { get; set; } = "bold";

        /// <summary>
        ///     Number of pixels to add above and below the title text.
        /// </summary>
        [JsonProperty(PropertyName = "padding")]
        public int Padding { get; set; } = 10;

        /// <summary>
        ///     Title text.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; } = "";
    }
}