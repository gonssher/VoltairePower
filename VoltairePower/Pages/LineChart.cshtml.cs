using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VoltairePower.Models;

namespace ChartApp.Pages
{
    public class LineChartModel : PageModel
    {
        public List<ChartData> chartDataList = new List<ChartData>();

        string connectionString;

        readonly IConfiguration _configuration;

        public LineChartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            chartDataList = ChartData();
        }

        private List<ChartData> ChartData()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<ChartData> chartDataList = new List<ChartData>();

            ChartData chartData = new ChartData();

            chartDataList = chartData.GetChartData(connectionString);

            return chartDataList;
        }
    }
}