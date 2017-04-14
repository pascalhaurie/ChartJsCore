using Newtonsoft.Json;
using jamiewest.ChartJs.Internal.ContractResolvers;

namespace jamiewest.ChartJs
{
    public class Chart
    {
        public Chart() { }

        public Chart(ChartOptions options)
        {
            Options = options;
        }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ChartData Data { get; set; } = new ChartData();

        [JsonProperty(PropertyName = "options")]
        public ChartOptions Options { get; set; } = new ChartOptions();

        public override string ToString()
        {
            //var settings = new JsonSerializerSettings();

            //settings.NullValueHandling = NullValueHandling.Ignore;
            //settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            //settings.Formatting = Formatting.Indented;
            //settings.ContractResolver = new ShouldSerializeContractResolver();

            //return JsonConvert.SerializeObject(this, settings);

            return JsonHelper.SerializeToMinimalJson(this);
        }
    }
}