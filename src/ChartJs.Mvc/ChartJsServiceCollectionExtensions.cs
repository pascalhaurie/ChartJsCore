using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using jamiewest.ChartJs;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ChartJsServiceCollectionExtensions
    {
        public static void AddChartJs(
            this IServiceCollection services,
            Action<ChartOptions> setupAction)
        {
        }
    }
}