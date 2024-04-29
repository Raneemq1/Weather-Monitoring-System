using WeatherMonitoringSystem.Observers;

namespace WeatherMonitoringSystem.Models
{
    public class SnowBot : Bot, IWeatherObserver
    {
        public double TemperatureThreshold { get; set; }
        public SnowBot(bool enabled, string message, double temperatureThreshold) : base(enabled, message)
        {
            TemperatureThreshold = temperatureThreshold;
        }
        public string Update(WeatherData weather)
        {
            if (weather.Tempreture < TemperatureThreshold) return Activate(weather); else return string.Empty;

        }

        public string Activate(WeatherData weather)
        {
            if (!Enabled) return string.Empty;
            return $"SnowBot:activated\n{Message}";

        }
    }
}
