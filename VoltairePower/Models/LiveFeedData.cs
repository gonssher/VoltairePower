using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class LiveFeedData
    {
        public double Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double Current_Phase_Average_Mean_A{ get; set; }
        public double Active_Energy_Delivered_Received_kWh{ get; set; }
        public double Active_Power_Kw{ get; set; }
        public double Weather_Temperature_Celsius{ get; set; }
        public double Weather_Relative_Humidity_Percent{ get; set; }
        public double Global_Horizontal_Radiation_WM2 { get; set; }
        public double Diffuse_Horizontal_Radiation_WM2{ get; set; }
        public double Wind_Direction_Degree{ get; set; }

    }
}
