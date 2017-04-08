using Newtonsoft.Json;

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
    }
}