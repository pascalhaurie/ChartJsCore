using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class BarChart : Chart
    {
        public BarChart() : base("bar") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<BarDataset> Data { get; } = new ChartData<BarDataset>();
    }
}