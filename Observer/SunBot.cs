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

        }

        public void Update(WeatherData weather)
        {

        }

        public bool Activation(WeatherData weather)
        {
            throw new NotImplementedException();
        }
    }
}
