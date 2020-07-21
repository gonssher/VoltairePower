using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VoltairePower.Models.Data_Layer
{
    public class PopulatingLineGraph
    {
        [Key]
        public double Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double Voltage { get; set; }

        public double TranslatedVoltage { get; set; }

    }
}
