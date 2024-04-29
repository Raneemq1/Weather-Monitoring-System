namespace WeatherMonitoringSystem.Serilaizers
{
    public interface ISerializer
    {
        T? Deserialize<T>(string data);
    }
}
