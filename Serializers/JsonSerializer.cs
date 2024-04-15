namespace WeatherMonitoringSystem.Serilaizers
{
    public class JsonSerializer : ISerializer
    {
        public T? Deserialize<T>(string data)
        {
            try
            {
                return System.Text.Json.JsonSerializer.Deserialize<T>(data);

            }
            catch
            {
                return default;
            }
        }
    }
}
