using Newtonsoft.Json;
using jamiewest.ChartJs.Utilities;
using Microsoft.Extensions.Options;

namespace jamiewest.ChartJs
{
    public class Chart
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ChartData Data { get; set; } = new ChartData();

        [JsonProperty(PropertyName = "options")]
        public ChartOptions Options { get; set; } = new ChartOptions();

        public override string ToString()
        {
            return JsonHelper.SerializeToMinimalJson(this);
        }
    }
}