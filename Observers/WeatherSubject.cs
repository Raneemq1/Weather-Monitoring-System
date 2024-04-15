using System.Text;
using WeatherMonitoringSystem.Models;

namespace WeatherMonitoringSystem.Observers
{
    public class WeatherSubject : IWeatherSubject
    {
        private List<IWeatherObserver> observers = new List<IWeatherObserver>();
       

        public void AddObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

        public string Notify(WeatherData weather)
        {
            StringBuilder activationMessages = new(); 
            foreach (IWeatherObserver observer in observers)
            {
                activationMessages.Append(observer.Update(weather));
            }
            return activationMessages.ToString();
        }
        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }

        public string SetWeatherValue(WeatherData weather)
        {
            return Notify(weather);
        }
    }
}
