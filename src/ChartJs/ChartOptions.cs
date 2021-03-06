using System.ComponentModel;
using System;
using Newtonsoft.Json;
using jamiewest.ChartJs.Options;

namespace jamiewest.ChartJs
{
    public class ChartOptions
    {
        /// <summary>
        ///     Resizes the chart canvas when its container does.
        /// </summary>
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "responsive")]
        public bool Responsive { get; set; } = true;

        /// <summary>
        ///     Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        [DefaultValue(0)]
        [JsonProperty(PropertyName = "responsiveAnimationDuration")]
        public int ResponsiveAnimationDuration { get; set; } = 0;

        /// <summary>
        ///     Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        /// 
        [DefaultValue(true)]
        [JsonProperty(PropertyName = "maintainAspectRatio")]
        public bool MaintainAspectRatio { get; set; } = true;

        /// <summary>
        ///     Events that the chart should listen to for tooltips and hovering.
        /// </summary>
        ///[DefaultValue(new string[] { "mousemove", "mouseout", "click", "touchstart", "touchmove", "touchend" })]
        [JsonProperty(PropertyName = "events")]
        public string[] Events { get; set; } 

        /// <summary>
        ///     Called if the event is of type 'mouseup' or 'click'. Called in the context 
        ///     of the chart and passed the event and an array of active elements.
        /// </summary>
        [JsonProperty(PropertyName = "onClick")]
        public bool OnClick { get; set; }

        /// <summary>
        ///     Function to generate a legend. Receives the chart object to generate a 
        ///     legend from. Default implementation returns an HTML string.
        /// </summary>
        [DefaultValue("function (chart) { }")]
        [JsonProperty(PropertyName = "legendCallback")]
        public string LegendCallback { get; set; } = "function (chart) { }";

        /// <summary>
        ///     Called when a resize occurs. Gets passed two arguments: the chart 
        ///     instance and the new size.
        /// </summary>
        [JsonProperty(PropertyName = "onResize")]
        public bool OnResize { get; set; }

        [JsonProperty(PropertyName = "animation")]
        public AnimationOptions Animation { get; set; } = new AnimationOptions();

        [JsonProperty(PropertyName = "elements")]
        public ElementOptions Elements { get; set; } = new ElementOptions();

        [JsonProperty(PropertyName = "hover")]
        public HoverOptions Hover { get; set; } = new HoverOptions();

        [JsonProperty(PropertyName = "layout")]
        public LayoutOptions Layout { get; set; } = new LayoutOptions();

        [JsonProperty(PropertyName = "legend")]
        public LegendOptions Legend { get; set; } = new LegendOptions();

        [JsonProperty(PropertyName = "scales")]
        public ScaleOptions Scales { get; set; } = new ScaleOptions();

        [JsonProperty(PropertyName = "title")]
        public TitleOptions Title { get; set; } = new TitleOptions();

        [JsonProperty(PropertyName = "tooltips")]
        public TooltipOptions Tooltip { get; set; } = new TooltipOptions();
    }
}