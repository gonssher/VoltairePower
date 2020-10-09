using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoltairePower.Models.Graphs
{
    public class PredictedAnalysis
    {

        public double Id { get; set; }
        public string Timestamp { get; set; }
        public double PredictedCurrent { get; set; }
        public double ExtraplatedCurrent { get; set; }

//        public List<PredictedAnalysis> GetChartData(string connectionString)
//        {
//            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

//            builder.DataSource = "voltaire.database.windows.net";
//            builder.UserID = "Sherwin";
//            builder.Password = "shannonnA4";
//            builder.InitialCatalog = "VoltairePowers";

//            List<PredictedAnalysis> chartDataList = new List<PredictedAnalysis>();
//            try
//            {
//                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
//                {
//                    connection.Open();
//                    StringBuilder sb = new StringBuilder();

//                    sb.Append("SELECT  ExtraplatedCurrent,FORMAT(Timestamp, 'MM.dd HH:mm') AS Timestamp , PredictedCurrent FROM PredictedData");

//                    String sql = sb.ToString();




//                    using (SqlCommand command = new SqlCommand(sql, connection))
//                    {
//                        using (SqlDataReader dr = command.ExecuteReader())
//                        {
//                            while (dr.Read())
//                            {


//                                PredictedAnalysis chartData = new PredictedAnalysis();

////                                chartData.Id = Convert.ToInt32(dr["Id"]);
//                                chartData.ExtraplatedCurrent = Convert.ToDouble(dr["ExtraplatedCurrent"]);
//                                chartData.Timestamp = dr["TimeStamp"].ToString();
//                                chartData.PredictedCurrent = Convert.ToDouble(dr["PredictedCurrent"]);
                          

//                                chartDataList.Add(chartData);
//                            }
//                        }
//                    }

//                }
//            }
//            catch (SqlException e)
//            { Console.WriteLine(e.ToString()); }

//            return chartDataList;


//        }




    }
}
