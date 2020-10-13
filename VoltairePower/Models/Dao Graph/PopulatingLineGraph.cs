using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VoltairePower.Models.Dao_Graph
{
    public class PopulatingLineGraph
    {



        public List<ChartData> GetChartData(string connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "voltaire.database.windows.net";
            builder.UserID = "Sherwin";
            builder.Password = "shannonnA4";
            builder.InitialCatalog = "VoltairePowers";

            List<ChartData> chartDataList = new List<ChartData>();
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT Id, FORMAT(Timestamp, 'MM.dd HH:mm') AS Timestamp, TranslatedVoltage, Voltage FROM LineChart");

                    String sql = sb.ToString();

                    //SELECT Id, FORMAT(Timestamp, 'MM.dd HH:mm') AS Timestamp, TranslatedVoltage, Voltage FROM LineChart


                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {


                                ChartData chartData = new ChartData();

                                chartData.Id = Convert.ToInt32(dr["Id"]);
                                chartData.TimeStamp = dr["TimeStamp"].ToString();
                                chartData.TranslatedVoltage = Convert.ToDouble(dr["TranslatedVoltage"]);
                                chartData.Voltage = Convert.ToDouble(dr["Voltage"]);

                                chartDataList.Add(chartData);
                            }
                        }
                    }

                }
            }

            catch (SqlException e)
            { Console.WriteLine(e.ToString()); }

            return chartDataList;


        }
    }
}
