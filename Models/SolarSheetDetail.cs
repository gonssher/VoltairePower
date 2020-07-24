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
/// <summary>
/// /////////////////////////////////////////////////////////////////////////////////
/// </summary>
        [Required(ErrorMessage = "Please enter the Solar Array Size")]
        [Display(Name = "Soalr Array Size (KW)", Prompt = "Solar Array Size")]
        public int SolarSize { get; set; }


        [Required(ErrorMessage = "Please input the Latitude Location")]
        [Display(Name = "Latitude Location", Prompt = "Array Location")]
        public string ArrayLocation { get; set; }

        [Required(ErrorMessage = "Please input the Longitude ")]
        [Display(Name = "Longitude Location", Prompt = " Array Location")]
        public string ArrayLocationLong { get; set; }

        [Required(ErrorMessage = "Please enter the Solar Plant Type")]
        [Display(Name = "Solar Plant Type", Prompt = "Solar Plant Type")]
        public SolarPlantType Type { get; set; }
/// <summary>
/// /////////////////////////////////////////////////////////////////////////////////
/// </summary>
        [Required(ErrorMessage = "Please enter the Number of Inverters")]
        [Display(Name = "Number Of Inverters", Prompt = "Number Of Inverters")]
        public int NumberofInverters { get; set; }

        [Required(ErrorMessage = "Please enter the Number of String Per Inverter")]
        [Display(Name = "Number of Strings Per Inverter", Prompt = "Number of String")]
        public int NumberOfSolarStrings { get; set; }

        [Required(ErrorMessage = "Please select the Solar Module Make")]
        [Display(Name = "Solar Module Make", Prompt = "Solar Module Make")]
        public string SolarModuleMake { get; set; }

        [Required(ErrorMessage = "Please input the Solar Module Power (W)")]
        [Display(Name = "Solar Module Power (W)", Prompt = "Solar Module Power (W)")]
        public string SolarModulePwr { get; set; }

        [Required(ErrorMessage = "Please enter the Module Open Circuit Voltage (Voc)")]
        [Display(Name = "Module Open Circuit Voltage (Voc)", Prompt = "Module Open Circuit Voltage (Voc)")]
        public double ModuleOpenShortCircuit { get; set; }

        [Required(ErrorMessage = "Please enter the Module Short Circuit Current (Isc)")]
        [Display(Name = "Module Short Circuit Current (Isc)", Prompt = "Module Short Circuit Current (Isc)")]
        public double ModuleShortCircuit { get; set; }

        [Required(ErrorMessage = "Please enter the Number of Modules per Series String")]
        [Display(Name = "Number of Modules per Series String", Prompt = "Number of Modules per Series String")]
        public double ModulePerSeries { get; set; }


        [Required(ErrorMessage = "Please enter theModule Temperature Coefficient")]
        [Display(Name = "Module Temperature Coefficient", Prompt = "Module Temperature Coefficient")]
        public double ModuleTempCoeff { get; set; }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        [Required(ErrorMessage = "Please enter the inverter Size (KW)")]
        [Display(Name = "Inverter Size (KW)", Prompt = "Inverter Size")]
        public double InverterSize { get; set; }

        [Required(ErrorMessage = "Please enter the DC Input Voltage")]
        [Display(Name = "DC Input Voltage Range", Prompt = "DC Input Voltage Range")]
        public string DcInput { get; set; }

        [Required(ErrorMessage = "Please enter Max Dc Current")]
        [Display(Name = "Max Dc Current", Prompt = "Max Dc Current")]
        public double MaxDc { get; set; }

        [Required(ErrorMessage = "Please enter the Peak Power Tracking Voltage")]
        [Display(Name = "Peak Power Tracking Voltage", Prompt = "Peak Power Tracking Voltage")]
        public double PeakPwrTv { get; set; }

        [Required(ErrorMessage = "Please enter Peak Inverter Efficiency")]
        [Display(Name = "Peak Inverter Efficiency", Prompt = "Peak Inverter Efficiency")]
        public double PeakInvEff { get; set; }

        [Required(ErrorMessage = "Please enter the AC Output Voltage (nominal)")]
        [Display(Name = "AC Output Voltage (nominal)", Prompt = "AC Output Voltage (nominal)")]
        public double AcOpVolt { get; set; }

        [Required(ErrorMessage = "Please enter the AC Voltage")]
        [Display(Name = "AC Voltage Range", Prompt = "AC Voltage ")]
        public string AcVolt { get; set; }

        [Required(ErrorMessage = "Please enter the AC Frequency (nominal)")]
        [Display(Name = "AC Frequency (nominal) Range", Prompt = "AC Frequency (nominal)")]
        public string AcFreqNorminal { get; set; }

        [Required(ErrorMessage = "Please enter the Max Continuous Output Current")]
        [Display(Name = "Max Continuous Output Current", Prompt = "Max Continuous Output Current")]
        public string MaxContinuousOC { get; set; }

        [Required(ErrorMessage = "Please enter the Power Factor ")]
        [Display(Name = "Power Factor", Prompt = "Power Factor")]
        public double PowerFact { get; set; }
/// <summary>
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>

        [Required(ErrorMessage = "Please enter the Wire Gauge per String")]
        [Display(Name = "Wire Gauge per String", Prompt = "Wire Gauge per String")]
        public int WireGPerStr { get; set; }


        [Required(ErrorMessage = "Please enter the Type of Wire")]
        [Display(Name = "Type of Wire", Prompt = "Type of Wire")]
        public WireGauge TypeofWire { get; set; }


        [Required(ErrorMessage = "Please enter the Total Length of string wiring (one way) ")]
        [Display(Name = "Total Length of string wiring One way (Feet)", Prompt = "Total Length of string wiring (one way)")]
        public double LengthOfString { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }


    public enum SolarPlantType
    {
        [Display(Name = "Grid Connected")]
        Grid,
        [Display(Name = "Community Solar")]
        Community,
        [Display(Name = "Stand Alone")]
        StandAlone
    }

    //public enum ArrayLoc
    //{ 
    //    Latitude,
    //    Longitude
    //}

    public enum WireGauge
    {
        PVwire,
        USE2

    }


}

