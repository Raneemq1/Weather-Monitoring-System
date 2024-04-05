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
