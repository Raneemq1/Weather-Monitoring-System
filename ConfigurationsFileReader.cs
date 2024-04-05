using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;
using WeatherMonitoringSystem.Observer;

namespace WeatherMonitoringSystem
{
    public class ConfigurationsFileReader
    {
        public ConfigurationsFileReader() { }

        public  IEnumerable<Bot> Read(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            string fileContent=File.ReadAllText(path);
            var bots = JsonSerializer.Deserialize<Dictionary<string,JsonElement>>(fileContent);

            foreach (var jsonObject in bots)
            {
                
                var botElement=jsonObject.Value;
                bool enabled = botElement.GetProperty("enabled").GetBoolean();
                string message=botElement.GetProperty("message").GetString();
                double humidityThreshold = 0;
                if (botElement.TryGetProperty("HumidityThreshold", out var humidityThresholdElement))
                {
                    humidityThreshold = humidityThresholdElement.GetDouble();
                }

                double temperatureThreshold = 0;
                if (botElement.TryGetProperty("TemperatureThreshold", out var temperatureThresholdElement))
                {
                    temperatureThreshold = temperatureThresholdElement.GetDouble();
                }

                switch (jsonObject.Key)
                {
                    case "RainBot": 
                        {
                            yield return new RainBot(enabled,message, humidityThreshold);
                            break;
                        }
                    case "SnowBot":
                        {
                            yield return new SnowBot(enabled, message, temperatureThreshold);
                          break;
                        }
                    case "SunBot":
                        {
                            yield return new SunBot(enabled, message, temperatureThreshold);
                            break;
                        }
                    default: Console.WriteLine("undefined bot type"); break;
                }

            }

        }
    }
}
