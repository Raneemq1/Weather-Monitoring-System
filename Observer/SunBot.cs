using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Observer
{
    public class SunBot : Bot, IBotObserver
    {
        private double tempretureThreshold;

        public SunBot(bool isEnabled, string message, double tempretureThreshold) : base(isEnabled, message, tempretureThreshold)
        {
            this.tempretureThreshold = tempretureThreshold;
        }

        public void Update(WeatherData weather)
        {
            if (Activation(weather))
            {
                Console.WriteLine($"SunBot:activated\n{Message}");
            }
        }

        public bool Activation(WeatherData weather)
        {
            if (IsEnabled && weather.Tempreture > tempretureThreshold)
            {
                return true;
            }
            return false;
        }
    }
}
