using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Observer
{
    public class RainBot : Bot, IBotObserver
    {
        private double humidityThresold;
        public RainBot(bool isEnabled, string message, double humidityThresold) : base(isEnabled, message, humidityThresold)
        {
            this.humidityThresold = humidityThresold; 
        }

        public void Update(WeatherData weather)
        {
            if (Activation(weather))
            {
                Console.WriteLine($"RainBot:activated\n{Message}");
            }
        }

        public bool Activation(WeatherData weather)
        {
            if (IsEnabled && weather.Humidity > humidityThresold)
            {
                return true;
            }
            return false;
        }
    }
}
