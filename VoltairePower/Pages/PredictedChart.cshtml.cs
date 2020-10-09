using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VoltairePower.Models;
using VoltairePower.Models.Graphs;
using VoltairePower.Models.Dao_Graph;

namespace ChartApp.Pages
{
    public class PredictedChartModel : PageModel
    {
        public List<PredictedAnalysis> chartDataList = new List<PredictedAnalysis>();

        string connectionString;

        readonly IConfiguration _configuration;

        public PredictedChartModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            chartDataList = PredictedAnalysis();
        }

        private List<PredictedAnalysis> PredictedAnalysis()
        {
            connectionString = _configuration.GetConnectionString("ConnectionString");

            List<PredictedAnalysis> chartDataList = new List<PredictedAnalysis>();

          //  PredictedAnalysis chartData = new PredictedAnalysis();
            PredictiveAnalysisDao chartDatPredictive = new PredictiveAnalysisDao();
            chartDataList = chartDatPredictive.GetChartData(connectionString);

           // chartDataList = chartData.GetChartData(connectionString);

            return chartDataList;
        }
    }
}