using WeatherMonitoringSystem.Models;

namespace WeatherMonitoringSystem.Observers
{
    public interface IWeatherObserver
    {
        string Update(WeatherData weather);
        string Activate(WeatherData weather);
    }
}
