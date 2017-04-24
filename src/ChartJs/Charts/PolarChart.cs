using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class PolarChart : Chart
    {
        public PolarChart() : base("polarArea") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<PolarDataset> Data { get; } = new ChartData<PolarDataset>();
    }
}