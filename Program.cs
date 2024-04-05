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

            IWeatherSubject subject = new WeatherSubject();
            AddBotObserversTOSubject(subject,bots);

           
        }

        public static IEnumerable<Bot> FileConfig()
        {
            ConfigurationsFileReader configFileReader = new ConfigurationsFileReader();

            return configFileReader.Read(FilePath.filePath);
        }
        public static void AddBotObserversTOSubject(IWeatherSubject subject ,IEnumerable<Bot> bots)
        {
            RainBot rainBot = (RainBot)bots.FirstOrDefault(bot => bot.GetType().Name is "RainBot");
            SnowBot snowBot = (SnowBot)bots.FirstOrDefault(bot => bot.GetType().Name is "SnowBot");
            SunBot sunBot = (SunBot)bots.FirstOrDefault(bot => bot.GetType().Name is "SunBot");
            subject.AddObserver(snowBot);
            subject.AddObserver(sunBot);
            subject.AddObserver(rainBot);
        }

       

    }
}
