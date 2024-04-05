using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Strategy
{
    public class JsonFileForm : IFileReader
    {
        public JsonFileForm() { }
        public WeatherData Read(string input)
        {
            WeatherData weather = JsonSerializer.Deserialize<WeatherData>(input);
            return weather;

        }
    }
}
