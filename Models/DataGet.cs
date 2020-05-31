using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class DataGet
    {
        public int Id { get; set; }
        public int Timestamp { get; set; }
        public int Current_Phase_Average_Mean_A{ get; set; }
        public int Active_Energy_Delivered_Received_kWh{ get; set; }
        public int Active_Power_Kw{ get; set; }
        public int Weather_Temperature_Celsius{ get; set; }
        public int Weather_Relative_Humidity_Percent{ get; set; }
        public int Global_Horizontal_Radiation_WM2 { get; set; }
        public int Diffuse_Horizontal_Radiation_WM2{ get; set; }
        public int Wind_Direction_Degree{ get; set; }

    }
}
