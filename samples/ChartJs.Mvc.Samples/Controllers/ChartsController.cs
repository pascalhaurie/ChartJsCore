using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using jamiewest.ChartJs.Charts;
using jamiewest.ChartJs.Datasets;
using jamiewest.ChartJs;

namespace ChartJs.Mvc.Samples.Controllers
{
    [Produces("application/json")]
    public class ChartsController : Controller
    {
        [HttpGet]
        [Route("api/chart/line/basic")]
        public string LineChartExample()
        {
            Chart chart = new Chart();

            chart.Type = "line";
            
            chart.Data.Labels = new string[] 
            { 
                "January", 
                "February", 
                "March", 
                "April", 
                "May", 
                "June", 
                "July" 
            };

            chart.Data.Datasets.Add(new LineDataset()
            {
                Label = "My First dataset",
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                Data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
                Fill = false
            });

            chart.Data.Datasets.Add(new LineDataset()
            {
                Label = "My Second dataset",
                Fill = false,
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                Data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }
            });


            chart.Options.Responsive = true;

            chart.Options.Title.Display = true;
            chart.Options.Title.Text = "Chart.js Line Chart";

            chart.Options.Tooltip.Mode = "index";
            chart.Options.Tooltip.Intersect = true;

            return chart.ToString();
        }
    }
}