namespace WeatherMonitoringSystem.Models
{
    public class WeatherData
    {
        public string? Location { get; set; }
        public double Humidity { get; set; }
        public double Tempreture { get; set; }

        public WeatherData(string? location, double humidity, double tempreture)
        {
            Location = location;
            Humidity = humidity;
            Tempreture = tempreture;
        }
    }
}
