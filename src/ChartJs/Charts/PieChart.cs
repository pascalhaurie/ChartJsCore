using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class PieChart : Chart
    {
        public PieChart() : base("pie") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<PieDataset> Data { get; } = new ChartData<PieDataset>();
    }
}