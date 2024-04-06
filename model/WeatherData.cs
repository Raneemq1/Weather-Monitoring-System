using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem.model
{
    public class WeatherData
    {
        public string? Location { get; set; }
        public double Humidity { get; set; }
        public double Tempreture { get; set; }

        public WeatherData() { }

        public WeatherData(string? location, double humidity, double tempreture)
        {
            Location = location;
            Humidity = humidity;
            Tempreture = tempreture;
        }
    }
}
