using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using jamiewest.ChartJs.Charts;
using jamiewest.ChartJs.Datasets;
using jamiewest.ChartJs;
using jamiewest.ChartJs.Options.Scales;

namespace ChartJs.Mvc.Samples.Controllers
{
    [Produces("application/json")]
    public class ChartsController : Controller
    {
        Random _randomNumber = new Random();

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
                Fill = false,
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                Data = new int[] 
                {
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor()
                }
            });

            chart.Data.Datasets.Add(new LineDataset()
            {
                Label = "My Second dataset",
                //Fill = false,
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                Data = new int[]
                {
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor()
                },
            });

            chart.Options.Responsive = true;

            chart.Options.Title.Display = true;
            chart.Options.Title.Text = "Chart.js Line Chart";

            chart.Options.Tooltip.Mode = "index";
            chart.Options.Tooltip.Intersect = true;

            chart.Options.Hover.Mode = "nearest";
            chart.Options.Hover.intersect = true;

            var xAxesCommonOption = new CommonOptions();

            xAxesCommonOption.Display = true;
            xAxesCommonOption.ScaleLabel.Display = true;
            xAxesCommonOption.ScaleLabel.LabelString = "Month";

            chart.Options.Scales.xAxes.Add(xAxesCommonOption);

            var yAxesCommonOption = new CommonOptions();

            yAxesCommonOption.Display = true;
            yAxesCommonOption.ScaleLabel.Display = true;
            yAxesCommonOption.ScaleLabel.LabelString = "Value";

            chart.Options.Scales.yAxes.Add(yAxesCommonOption);

            return chart.ToString();
        }

        [HttpGet]
        [Route("api/chart/bar/basic")]
        public string BarChartExample()
        {
            BarChart chart = new BarChart();

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

            chart.Data.Datasets.Add(new BarDataset()
            {
                Label = "My First dataset",
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                Data = new int[]
                {
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor()
                }
            });

            chart.Data.Datasets.Add(new LineDataset()
            {
                Label = "My Second dataset",
                BackgroundColor = new string[] { "rgba(54, 162, 235, 0.2)" },
                BorderColor = new string[] { "rgba(54, 162, 235, 1)" },
                Data = new int[]
                {
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor(),
                    RandomScalingFactor()
                },
            });

            chart.Options.Responsive = true;

            chart.Options.Title.Display = true;
            chart.Options.Title.Text = "Chart.js Line Chart";

            chart.Options.Tooltip.Mode = "index";
            chart.Options.Tooltip.Intersect = true;

            chart.Options.Hover.Mode = "nearest";
            chart.Options.Hover.intersect = true;

            var xAxesCommonOption = new CommonOptions();

            xAxesCommonOption.Display = true;
            xAxesCommonOption.ScaleLabel.Display = true;
            xAxesCommonOption.ScaleLabel.LabelString = "Month";

            chart.Options.Scales.xAxes.Add(xAxesCommonOption);

            var yAxesCommonOption = new CommonOptions();

            yAxesCommonOption.Display = true;
            yAxesCommonOption.ScaleLabel.Display = true;
            yAxesCommonOption.ScaleLabel.LabelString = "Value";

            chart.Options.Scales.yAxes.Add(yAxesCommonOption);

            return chart.ToString();
        }

        private int RandomScalingFactor()
        {
            return _randomNumber.Next(-100, 100);
        }
    }
}