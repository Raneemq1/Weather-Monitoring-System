namespace WeatherMonitoringSystem.Models
{
    public class Bot
    {
        public bool Enabled { get; set; }
        public string Message { get; set; }
     

        public Bot(bool enabled, string message)
        {
            Enabled = enabled;
            Message = message;
        }
    }
}
