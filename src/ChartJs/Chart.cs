using Newtonsoft.Json;
using jamiewest.ChartJs.Utilities;
using Microsoft.Extensions.Options;

namespace jamiewest.ChartJs
{
    public class Chart
    {
        public Chart()
        {
            Options = new ChartOptions();
        }

        public Chart(IOptions<ChartOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new ChartOptions();
        }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "data")]
        public ChartData Data { get; set; } = new ChartData();

        [JsonProperty(PropertyName = "options")]
        public ChartOptions Options { get; set; } 

        public override string ToString()
        {
            return JsonHelper.SerializeToMinimalJson(this);
        }
    }
}