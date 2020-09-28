using VoltairePower.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
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
