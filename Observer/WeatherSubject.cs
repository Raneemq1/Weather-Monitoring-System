using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Observer
{
    public class WeatherSubject : IWeatherSubject
    {
        private List<IBotObserver> observers = new List<IBotObserver>();
        private WeatherData weather;

        public WeatherSubject() { }
        public void AddObserver(IBotObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (IBotObserver observer in observers)
            {
                observer.Update(weather);
            }
        }

        public void RemoveObserver(IBotObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetWeatherValue(WeatherData weather)
        {
            this.weather = weather;
            Notify();
        }
    }
}
