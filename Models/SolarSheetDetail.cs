using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class SolarSheetDetail
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Solar Type")]
        [Required(ErrorMessage = "Please enter solar type")]
        public string SolarType { get; set; }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Please enter company name")]
        public string CompanyName { get; set; }

        [Display(Name = "Installed Date")]
        [Required(ErrorMessage = "Please pick the installed date")]
        [DataType(DataType.Date)]
        public DateTime InstalledDate { get; set; }

        [Display(Name = "Max Power")]
        public string MaxPower { get; set; }

        [Display(Name = "Operating Voltage")]
        public string OperatingVoltage { get; set; }

        [Display(Name = "Module Efficiency")]
        public string ModuleEffeciency { get; set; }

        [Display(Name = "Operating Temperature")]
        public string OperatingTemperature { get; set; }

        [Display(Name = "Cable Connector")]
        public string CableConnector { get; set; }

        [Display(Name = "Quantity")]
        [Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
