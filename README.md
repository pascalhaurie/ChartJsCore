# ChartJs
[![Build status](https://ci.appveyor.com/api/projects/status/v2bva9w2a84vpkoa/branch/master?svg=true)](https://ci.appveyor.com/project/jamiewest/chartjs/branch/master)

Chart.js wrapper for use in ASP.NET Core, see (http://www.chartjs.org).

## Installation

## How do I use it?
Using ChartJs in your ASP.NET Core application requires the use of a web api controller and adding a canvas tag in the view where you want your chart to appear. The canvas tag uses a TagHelper that adds a Url property that will reference the location of your controller that will return the serialized json that will configure the chart.  

### Setting up your controller
Consider the following example that will setup a basic line chart.

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
            1,
            20, 
            5, 
            17,
            3,
            9,
            13
        }
    });

    chart.Options.Title.Display = true;
    chart.Options.Title.Text = "Chart.js Line Chart";

    return chart.ToString();
}
```

### Setting up the view
Now that we have a controller configured that will deliver our Chart config, we just need to add the following into a view to load the chart.

```html
<div style="width:75%;">
    <canvas id="canvas" url="api/Chart/Line/Basic"></canvas>
</div>
```
