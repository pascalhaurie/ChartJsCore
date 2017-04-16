# ChartJs
Chart.js wrapper for use in ASP.NET Core, see (http://www.chartjs.org).

## Installation

## How do I use it?

Controller setup:
```csharp
[HttpGet]
[Route("api/chart/line/basic")]
public string BasicLineChart()
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

    chart.Options.Title.Display = true;
    chart.Options.Title.Text = "Chart.js Line Chart";

    return chart.ToString();
}
```

View:
```html
<div style="width:75%;">
    <canvas id="canvas" url="api/Chart/Line/Basic"></canvas>
</div>
```
