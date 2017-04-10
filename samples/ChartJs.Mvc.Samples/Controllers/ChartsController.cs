using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using jamiewest.ChartJs.Charts;
using jamiewest.ChartJs.Datasets;

namespace ChartJs.Mvc.Samples.Controllers
{
    [Produces("application/json")]
    [Route("api/Charts")]
    public class ChartsController : Controller
    {
        [HttpGet]
        public string LineChartExample()
        {
            LineChart chart = new LineChart();
            
            chart.Data.Labels = new string[] 
            { 
                "January", 
                "February", 
                "March", 
                "April", 
                "May", 
                "June", 
                "July", 
                "August", 
                "September", 
                "October", 
                "November", 
                "December" 
            };

            chart.Data.Datasets.Add(new LineDataset()
            {
                Label = "Line chart data",
                Data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                BorderWidth = 1
            });

            chart.Options.Title.Text = "Line Chart";

            return chart.ToString();
        }
    }
}