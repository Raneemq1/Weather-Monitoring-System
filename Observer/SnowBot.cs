using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Observer
{
    public class SnowBot :Bot, IBotObserver
    {
        private double tempretureThreshold;
        public SnowBot(bool isEnabled, string message, double tempretureThreshold) : base(isEnabled, message, tempretureThreshold)
        {
            this.tempretureThreshold = tempretureThreshold;
        }
        public void Update(WeatherData weather)
        {
            if (Activation(weather))
            {
                Console.WriteLine($"SnowBot:activated\n{Message}");
            }
        }

        public bool Activation(WeatherData weather)
        {
            if (IsEnabled && weather.Tempreture < tempretureThreshold)
            {
                return true;
            }
            return false;
        }
    }
}
