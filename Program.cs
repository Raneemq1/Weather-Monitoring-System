using WeatherMonitoringSystem.model;
using WeatherMonitoringSystem.Observer;
using WeatherMonitoringSystem.utils;

namespace WeatherMonitoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Monitoring System");
            var bots = FileConfig();
            
      

        }

        public static IEnumerable<Bot> FileConfig()
        {
            ConfigurationsFileReader configFileReader = new ConfigurationsFileReader();

            return configFileReader.Read(FilePath.filePath);
        }

       
    }
}
