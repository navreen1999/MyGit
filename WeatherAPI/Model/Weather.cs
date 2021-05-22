using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Model
{
    public class Weather
    {
        [Key]
        public string City { get; set; }
        public DateTime Date { get; set; }
        public float highTemp { get; set; }
        public float lowTemp { get; set; }
        public string Forecast { get; set; }
    }
}
