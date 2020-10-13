using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VoltairePower.Models;
using VoltairePower.Models.Dao_Graph;

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
            chartDataList = PopulatingLineGraph();
        }

        private List<ChartData> PopulatingLineGraph()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<ChartData> chartDataList = new List<ChartData>();

            //     ChartData chartData = new ChartData();

            PopulatingLineGraph chartDataDao = new PopulatingLineGraph();

            chartDataList = chartDataDao.GetChartData(connectionString);
           // chartDataList = chartData.GetChartData(connectionString);

            return chartDataList;
        }
    }
}