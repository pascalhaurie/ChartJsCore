using jamiewest.ChartJs;
using jamiewest.ChartJs.Data;
using Newtonsoft.Json;

namespace jamiewest.ChartJs.Charts
{
    public class BubbleChart : Chart
    {
        public BubbleChart() : base("bubble") { }

        [JsonProperty(PropertyName = "data")]
        public ChartData<BubbleDataset> Data { get; } = new ChartData<BubbleDataset>();
    }
}