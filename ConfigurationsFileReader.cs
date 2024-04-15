using Microsoft.Extensions.Configuration;
using WeatherMonitoringSystem.Models;


namespace WeatherMonitoringSystem
{
    public class ConfigurationsFileReader
    {
        public IEnumerable<Bot> Read(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("config.json").Build();
            yield return config.GetSection(nameof(RainBot)).Get<RainBot>()??throw new Exception("");
            yield return config.GetSection(nameof(SunBot)).Get<SunBot>() ?? throw new Exception("");
            yield return config.GetSection(nameof(SnowBot)).Get<SnowBot>()?? throw new Exception("");

        }
    }
}
