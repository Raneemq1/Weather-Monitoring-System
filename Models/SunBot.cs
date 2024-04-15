using WeatherMonitoringSystem.Observers;

namespace WeatherMonitoringSystem.Models
{
    public class SunBot : Bot, IWeatherObserver
    {
        public double TemperatureThreshold { get; set; }

        public SunBot(bool enabled, string message, double temperatureThreshold) : base(enabled, message)
        {
            TemperatureThreshold = temperatureThreshold;
        }

        public string Update(WeatherData weather)
        {
            if (weather.Tempreture > TemperatureThreshold) return Activate(weather); else return string.Empty;

        }

        public string Activate(WeatherData weather)
        {
            if (!Enabled) return string.Empty;
            return $"SunBot:activated\n{Message}";

        }
    }
}
