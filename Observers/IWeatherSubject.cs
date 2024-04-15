using WeatherMonitoringSystem.Models;

namespace WeatherMonitoringSystem.Observers
{
    public interface IWeatherSubject
    {
        void AddObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        string Notify(WeatherData weather);
    }
}
