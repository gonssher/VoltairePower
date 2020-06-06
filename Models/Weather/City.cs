using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models.Weather
{
    public class City
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public string ID { get; set; }

        [Display(Name = "City:")]
        public string Name { get; set; }

        [Display(Name = "Temperature:")]
        public float Temp { get; set; }

        [Display(Name = "Humidity")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }

        [Display(Name = "Clouds:")]
        public int Clouds { get; set; }

        [Display(Name = "Sunshine:")]
        public int Sunshine { get; set; }

        [Display(Name = "Sunrise:")]
        public int Sunrise { get; set; }

        public DateTime WeatherDateTime { get; set; } = DateTime.Now;
    }
}
