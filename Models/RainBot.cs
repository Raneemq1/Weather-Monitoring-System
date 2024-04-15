using WeatherMonitoringSystem.Observers;

namespace WeatherMonitoringSystem.Models
{
    public class RainBot : Bot, IWeatherObserver
    {
        public double HumidityThreshold { get; set; }
        public RainBot(bool enabled, string message, double humidityThreshold) : base(enabled, message)
        {
            HumidityThreshold = humidityThreshold;
        }

        public string Update(WeatherData weather)
        {
            if (weather.Humidity > HumidityThreshold) return Activate(weather); else return string.Empty;

        }

        public string Activate(WeatherData weather)
        {
            if (!Enabled) return string.Empty;
            return $"RainBot:activated\n{Message}";

        }
    }
}
