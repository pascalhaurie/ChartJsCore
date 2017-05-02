using Newtonsoft.Json;
using jamiewest.ChartJs.Utilities;

namespace jamiewest.ChartJs
{
    public abstract class Chart
    {
        private readonly string _type;

        public Chart(string type)
        {
            _type = type;
        }

        [JsonProperty(PropertyName = "type")]
        public string Type 
        { 
            get
            {
                return _type;
            } 
        }

        [JsonProperty(PropertyName = "options")]
        public ChartOptions Options { get; set; } = new ChartOptions();

        public override string ToString()
        {
            return JsonHelper.SerializeToMinimalJson(this);
        }
    }
}