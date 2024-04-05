using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem.Observer
{
    public interface IWeatherSubject
    {
        void AddObserver(IBotObserver observer);
        void RemoveObserver(IBotObserver observer);
        void Notify();
    }
}
