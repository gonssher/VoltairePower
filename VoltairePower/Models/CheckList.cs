﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class CheckList
    {
        public int Id { get; set; }

        [Display(Name = "AC Power Output Measurement & Comparison")]
        public bool ac_out { get; set; }
        [Display(Name = "Energy Production Measurement & Comparison")]
        public bool energy_prod { get; set; }
        [Display(Name = "Inspect Panels for Damage")]
        public bool inspect_panel { get; set; }
        [Display(Name = "Address Shading Issues")]
        public bool shading_issue { get; set; }
        [Display(Name = "Clean Panels")]
        public bool panel_clean { get; set; }
        [Display(Name = "Inspect Array Mounting System")]
        public bool inspect_array_mount { get; set; }
        [Display(Name = "Adjust Array Tilt", Prompt = "Full Name")]
        public bool array_tilt { get; set; }
        [Display(Name = "Check inverter and/or Charge Controller for correct settings")]
        public bool charge_ctrl_settings { get; set; }
        [Display(Name = "Test Batteries according to manufacturers specs")]
        public bool battery_test { get; set; }
        [Display(Name = "Inspect and clean all electrical equipment")]
        public bool clean_elect_equipment { get; set; }
        [Display(Name = "Monitor System for Voltage and Current")]
        public bool monitor_volt_current { get; set; }
        [Display(Name = "AC Power Output Measurement & Comparison")]
        public bool Mac_out { get; set; }
        [Display(Name = "Energy Production Measurement & Comparison")]
        public bool Menergy_prod { get; set; }
        [Display(Name = "Inspect Panels for Damage")]
        public bool Minspect_panel { get; set; }
        [Display(Name = "Address Shading Issues")]
        public bool Mshading_issue { get; set; }
        [Display(Name = "Clean Panels")]
        public bool Mpanel_clean { get; set; }
        [Display(Name = "Inspect Array Mounting System")]
        public bool Minspect_array_mount { get; set; }
        [Display(Name = "Adjust Array Tilt", Prompt = "Full Name")]
        public bool Marray_tilt { get; set; }
        [Display(Name = "Check inverter and/or Charge Controller for correct settings")]
        public bool Mcharge_ctrl_settings { get; set; }
        [Display(Name = "Test Batteries according to manufacturers specs")]
        public bool Mbattery_test { get; set; }
        [Display(Name = "Inspect and clean all electrical equipment")]
        public bool Mclean_elect_equipment { get; set; }
        [Display(Name = "Monitor System for Voltage and Current")]
        public bool Mmonitor_volt_current { get; set; }

        [Display(Name = "AC Power Output Measurement & Comparison")]
        public bool Sac_out { get; set; }
        [Display(Name = "Energy Production Measurement & Comparison")]
        public bool Senergy_prod { get; set; }
        [Display(Name = "Inspect Panels for Damage")]
        public bool Sinspect_panel { get; set; }
        [Display(Name = "Address Shading Issues")]
        public bool Sshading_issue { get; set; }
        [Display(Name = "Clean Panels")]
        public bool Spanel_clean { get; set; }
        [Display(Name = "Inspect Array Mounting System")]
        public bool Sinspect_array_mount { get; set; }
        [Display(Name = "Adjust Array Tilt", Prompt = "Full Name")]
        public bool Sarray_tilt { get; set; }
        [Display(Name = "Check inverter and/or Charge Controller for correct settings")]
        public bool Scharge_ctrl_settings { get; set; }
        [Display(Name = "Test Batteries according to manufacturers specs")]
        public bool Sbattery_test { get; set; }
        [Display(Name = "Inspect and clean all electrical equipment")]
        public bool Sclean_elect_equipment { get; set; }
        [Display(Name = "Monitor System for Voltage and Current")]
        public bool Smonitor_volt_current { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

  
    }
}
