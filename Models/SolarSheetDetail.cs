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

        [Required(ErrorMessage = "Please enter the Solar Size")]
        [Display(Name = "Soalr Size", Prompt = "Solar Size")]
        public int SolarSize { get; set; }

        [Required(ErrorMessage = "Please enter the Solar Plant Type")]
        [Display(Name = "Solar Plant Type", Prompt = "Solar Plant Type")]
        public SolarPlantType Type { get; set; }

        [Required(ErrorMessage = "Please enter the Number of Inverters")]
        [Display(Name = "Number Of Inverters", Prompt = "Number Of Inverters")]
        public int NumberofInverters { get; set; }

        [Required(ErrorMessage = "Please select the Inverter Make")]
        [Display(Name = "Inverter Make", Prompt = "Inverter Make")]
        public InverterMake InverterMakes { get; set; }

        [Required(ErrorMessage = "Please Select the Inverter Model")]
        [Display(Name = "Inverter Model", Prompt = "Inverter Model")]
        public InverterModels InverterModel { get; set; }

        [Required(ErrorMessage = "Please enter the inverter Size")]
        [Display(Name = "Inverter Size", Prompt = "Inverter Size")]
        public int InverterSize { get; set; }

        [Required(ErrorMessage = "Please enter the Number of Solar String")]
        [Display(Name = "Number of Solar String", Prompt = "Number of Solar String")]
        public int NumberOfSolarStrings { get; set; }

        [Required(ErrorMessage = "Please Select the Solar String Connection")]
        [Display(Name = "Solar String Connection", Prompt = "Solar String Connection")]
        public SolarStringsolarConnectionType SolarStringsolarConnection { get; set; }

        [Required(ErrorMessage = "Please enter the Solar String Model")]
        [Display(Name = "Solar String Model", Prompt = "Solar String Model")]
        public string SolarStringsolarModel { get; set; }

        [Required(ErrorMessage = "Please enter the Number of Watts")]
        [Display(Name = "Number of Watts", Prompt = "Number of Watts")]
        public int NumberOfWatts { get; set; }

        [Required(ErrorMessage = "Please enter the Voltage, maximum powerpoint")]
        [Display(Name = "Maximum PowerPoint", Prompt = "Maximum PowerPoint")]
        public int Vmpp { get; set; }

        [Required(ErrorMessage = "Please enter Voltage, Open Circuit")]
        [Display(Name = "Voltage", Prompt = "Voltage")]
        public int Voc { get; set; }

        [Required(ErrorMessage = "Please enter the Current, maximum powerpoint")]
        [Display(Name = "Current", Prompt = "Current")]
        public int Impp { get; set; }

        [Required(ErrorMessage = "Please enter the Short Circuit")]
        [Display(Name = "Short Circuit", Prompt = "Short Circuit")]
        public int Isc { get; set; }

        [Required(ErrorMessage = "Please enter the Temperature Coefficient")]
        [Display(Name = "Temperature Coefficient", Prompt = "Temperature Coefficient")]
        public int TemCoeffoicient { get; set; }
        public virtual Customer Customer { get; set; }
    }


    public enum SolarPlantType
    {
        [Display(Name = "Grid Connected")]
        Grid,
        [Display(Name = "Community Solar")]
        Community,
        [Display(Name = "Stand Alone")]
        Stand
    }


    public enum InverterMake
    {
        Fronius,
        Sungrow,
        Tigo
    }

    public enum InverterModels
    {
        [Display(Name = "Sukam shiny series")]
        Sukam,
        [Display(Name = "Microtek UPS SEBz series")]
        Microtek,
        [Display(Name = "Exide Home UPS")]
        Exide,
        [Display(Name = "APC Home UPS")]
        APC

    }


    public enum SolarStringsolarConnectionType
    {
        [Display(Name = "Parallel Connection")]
        parallel,
        [Display(Name = "Series Connection")]
        series


    }

}

