using System;
using jamiewest.ChartJs.Charts;

namespace ChartJs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LineChart chart = new LineChart();
            
            Console.WriteLine(chart.ToString());
        }
    }
}
