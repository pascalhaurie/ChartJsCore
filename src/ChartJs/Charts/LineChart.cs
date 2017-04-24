using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class LineChart : Chart
    {
        public LineChart() : base("line") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<LineDataset> Data { get; } = new ChartData<LineDataset>();
    }
}