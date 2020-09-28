using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models.Graph_Tables
{
    public class PredictedActual
    {

        [Key]
        public double Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double PredictedCurrent { get; set; }
        public double ExtraplatedCurrent { get; set; }


    }
}
