using Newtonsoft.Json;
using jamiewest.ChartJs.ContractResolver;

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
            var settings = new JsonSerializerSettings();

            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
            settings.ContractResolver = new ShouldSerializeContractResolver();

            return JsonConvert.SerializeObject(this, settings);
        }
    }
}