using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Observer
{
    public interface IBotObserver
    {  
        void Update(WeatherData weather);
        bool Activation(WeatherData weather);
    }
}
