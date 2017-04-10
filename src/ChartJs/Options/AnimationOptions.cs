using System.ComponentModel;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Options
{
    public class AnimationOptions
    {
        /// <summary>
        ///     The number of milliseconds an animation takes. 
        /// </summary>
        [DefaultValue(1)]
        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; } = 1;

        /// <summary>
        ///     Easing function to use. Available options are: 'linear', 'easeInQuad', 
        ///     'easeOutQuad', 'easeInOutQuad', 'easeInCubic', 'easeOutCubic', 'easeInOutCubic', 
        ///     'easeInQuart', 'easeOutQuart', 'easeInOutQuart', 'easeInQuint', 'easeOutQuint', 
        ///     'easeInOutQuint', 'easeInSine', 'easeOutSine', 'easeInOutSine', 'easeInExpo', 
        ///     'easeOutExpo', 'easeInOutExpo', 'easeInCirc', 'easeOutCirc', 'easeInOutCirc', 
        ///     'easeInElastic', 'easeOutElastic', 'easeInOutElastic', 'easeInBack', 'easeOutBack', 
        ///     'easeInOutBack', 'easeInBounce', 'easeOutBounce', 'easeInOutBounce'. 
        /// </summary>
        [DefaultValue("easeOutQuart")]
        [JsonProperty(PropertyName = "easing")]
        public string Easing { get; set; } = "easeOutQuart";

        /// <summary>
        ///     Callback called on each step of an animation. Passed a single argument, an object, 
        ///     containing the chart instance and an object with details of the animation.
        /// </summary>
        [JsonProperty(PropertyName = "onProgress")]
        public string OnProgress { get; set; } 

        /// <summary>
        ///     Callback called at the end of an animation. Passed the same arguments as onProgress. 
        /// </summary>
        [JsonProperty(PropertyName = "onComplete")]
        public string OnComplete { get; set; }
    }
}