using WeatherMonitoringSystem.model;
using WeatherMonitoringSystem.Observer;
using WeatherMonitoringSystem.Strategy;
using WeatherMonitoringSystem.utils;

namespace WeatherMonitoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Monitoring System");

            try
            {
                var bots = FileConfig();
               
                WeatherSubject subject = new WeatherSubject();

                AddBotObserversTOSubject(subject, bots);

                WeatherData weather = UserInput();

                subject.SetWeatherValue(weather);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static IEnumerable<Bot> FileConfig()
        {
            ConfigurationsFileReader configFileReader = new ConfigurationsFileReader();

            return configFileReader.Read(FilePath.filePath);
        }
        public static void AddBotObserversTOSubject(IWeatherSubject subject, IEnumerable<Bot> bots)
        {
            RainBot rainBot = (RainBot)bots.FirstOrDefault(bot => bot.GetType().Name is "RainBot");
            SnowBot snowBot = (SnowBot)bots.FirstOrDefault(bot => bot.GetType().Name is "SnowBot");
            SunBot sunBot = (SunBot)bots.FirstOrDefault(bot => bot.GetType().Name is "SunBot");
            subject.AddObserver(snowBot);
            subject.AddObserver(sunBot);
            subject.AddObserver(rainBot);
        }

        public static WeatherData UserInput()
        {
            Console.WriteLine("Enter the Weather Data");
            string input = Console.ReadLine();
            IFileReader inputForm;
            if (input.Contains('<'))
            {
                inputForm = new XMLFileForm();
            }
            else
            {
                inputForm = new JsonFileForm();
            }

            FileFormReader inputReader = new FileFormReader(inputForm);
            WeatherData weatherData = inputReader.Read(input);
            return weatherData;
        }

    }
}
