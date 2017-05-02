using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class DoughnutChart : Chart
    {
        public DoughnutChart() : base("doughnut") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<PieDataset> Data { get; } = new ChartData<PieDataset>();
    }
}