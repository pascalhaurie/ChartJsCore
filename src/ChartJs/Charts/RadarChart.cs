using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class RadarChart : Chart
    {
        public RadarChart() : base("radar") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<RadarDataset> Data { get; } = new ChartData<RadarDataset>();
    }
}