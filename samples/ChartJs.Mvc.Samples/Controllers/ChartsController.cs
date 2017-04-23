using System;
using Microsoft.AspNetCore.Mvc;
using jamiewest.ChartJs.Charts;
using jamiewest.ChartJs.Datasets;
using jamiewest.ChartJs;
using jamiewest.ChartJs.Options.Scales;
using ChartJs.Mvc.Samples.Utilities;
using Microsoft.Extensions.Options;

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
            LineChart chart = new LineChart();
            
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
                BackgroundColor = new string[] { ChartColors.Red },
                BorderColor = new string[] { ChartColors.Red },
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
                Fill = false,
                BackgroundColor = new string[] { ChartColors.Blue },
                BorderColor = new string[] { ChartColors.Blue },
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
            //chart.Options.Title.Text = "Chart.js Line Chart";

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
                BackgroundColor = new string[] { "rgba(255, 99, 132, .5)" },
                BorderColor = new string[] { ChartColors.Red },
                BorderWidth = new int[] { 1 },
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

            chart.Data.Datasets.Add(new BarDataset()
            {
                Label = "My Second dataset",
                BackgroundColor = new string[] { "rgba(54, 162, 235, .5)" },
                BorderColor = new string[] { ChartColors.Blue },
                BorderWidth = new int[] { 1 },
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
        [Route("api/chart/pie/basic")]
        public string PieChartExample()
        {
            PieChart chart = new PieChart();

            chart.Data.Labels = new string[]
            {
                "Red",
                "Orange",
                "Yellow",
                "Green",
                "Blue"
            };

            chart.Data.Datasets.Add(new PieDataset()
            {
                Label = "Dataset 1",
                Data = new int[]
                {
                    10,
                    20,
                    30,
                    30,
                    20
                },
                BackgroundColor = new string[]
                {
                    ChartColors.Red,
                    ChartColors.Orange, 
                    ChartColors.Yellow,
                    ChartColors.Green,
                    ChartColors.Blue
                }
            });

            return chart.ToString();
        } 

        private int RandomScalingFactor(int min = -100, int max = 100)
        {
            return _randomNumber.Next(-100, 100);
        }
    }
}