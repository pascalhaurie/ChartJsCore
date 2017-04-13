using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using jamiewest.ChartJs.Options.Scales;

namespace jamiewest.ChartJs.Options
{
    public class ScaleOptions
    {
        public List<CommonOptions> xAxes { get; set; } = new List<CommonOptions>();
        public List<CommonOptions> yAxes { get; set; } = new List<CommonOptions>();
    }
}
