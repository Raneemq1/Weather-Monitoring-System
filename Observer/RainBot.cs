using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Observer
{
    public class RainBot : Bot,IBotObserver
    {
        private double humidityThresold;
        public RainBot(bool isEnabled, string message, double humidityThresold) : base(isEnabled, message, humidityThresold)
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
