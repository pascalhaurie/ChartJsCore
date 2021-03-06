using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options
{
    public class LabelsOptions
    {
        /// <summary>
        ///     Is the legend displayed.
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "display")]
        public bool Display { get; set; } = true;

        /// <summary>
        ///     Position of the legend. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        [DefaultValue("top")]
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; } = "top";

        /// <summary>
        ///     Marks that this box should take the full width of the canvas (pushing down other boxes).
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "fullWidth")]
        public bool FullWidth { get; set; } = true;

        
    }
}