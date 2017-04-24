using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class HorizontalBarChart : Chart
    {
        public HorizontalBarChart() : base("horizontalBar") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<BarDataset> Data { get; } = new ChartData<BarDataset>();
    }
}