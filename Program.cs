using WeatherMonitoringSystem;
using WeatherMonitoringSystem.Models;
using WeatherMonitoringSystem.Observers;
using WeatherMonitoringSystem.Serilaizers;
using WeatherMonitoringSystem.Utils;

Console.WriteLine("Weather Monitoring System");

try
{
    var bots = FileConfig();

    WeatherSubject subject = new WeatherSubject();

    AddBotObserversTOSubject(subject, bots);

    WeatherData weather = UserInput();

    Console.WriteLine(subject.SetWeatherValue(weather)); 

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


IEnumerable<Bot> FileConfig()
{
    ConfigurationsFileReader configFileReader = new ConfigurationsFileReader();

    return configFileReader.Read(FilePath.filePath);
}
void AddBotObserversTOSubject(IWeatherSubject subject, IEnumerable<Bot> bots)
{
    RainBot rainBot = (RainBot)bots.FirstOrDefault(bot => bot.GetType() == typeof(RainBot));
    SnowBot snowBot = (SnowBot)bots.FirstOrDefault(bot => bot.GetType() == typeof(SnowBot));
    SunBot sunBot = (SunBot)bots.FirstOrDefault(bot => bot.GetType() == typeof(SunBot));
    subject.AddObserver(snowBot);
    subject.AddObserver(sunBot);
    subject.AddObserver(rainBot);
}

WeatherData UserInput()
{
    Console.WriteLine("Enter the Weather Data");
    var input = Console.ReadLine() ?? throw new Exception("Error while trying to read input");
    IEnumerable<ISerializer> serializers = [new JsonSerializer(), new XMLSerializer()];

    foreach (var serializer in serializers)
    {
        var weatherData = serializer.Deserialize<WeatherData>(input);
        if (weatherData is not null) return weatherData;
    }
    throw new Exception("Input format not clear, Use JSON or XML");
}
