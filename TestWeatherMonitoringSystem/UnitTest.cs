using AutoFixture;
using FluentAssertions;
using Moq;
using WeatherMonitoringSystem.Models;
using WeatherMonitoringSystem.Serilaizers;
using WeatherMonitoringSystem;

namespace TestWeatherMonitoringSystem
{
    public class UnitTest
    {
        private readonly Fixture _fixture;

        public UnitTest()
        {
            _fixture = new Fixture();
        }

        [Fact]
       
        public void Should_OutputMessageNotBeEmpty_WhenHumidityIsMoreThanHumdityThresold()
        {
            //Arrange 
            RainBot bot = new RainBot(true, "yay", 75);
            WeatherData weather = _fixture.Create<WeatherData>();
            weather.Humidity = 85;

            //Act
            string outputMessage = bot.Update(weather);

            //Assert
            outputMessage.Should().NotBeEmpty();

        }

        [Theory]
        [InlineData(65)]
        public void Should_OutputMessageBeEmpty_WhenHumidityIsLessThanHumdityThresold(double humidity)
        {
            //Arrange 
            RainBot bot = new RainBot(true, "yay", 75);
            WeatherData weather = _fixture.Create<WeatherData>();
            weather.Humidity = humidity;

            //Act
            string outputMessage = bot.Update(weather);

            //Assert
            outputMessage.Should().BeEmpty();

        }
       
        [Fact]
        public void Should_WeatherDataNotBeNull_When_DeserializeJson()
        {
            // Arrange 
            Mock<ISerializer> mockSerializer=new Mock<ISerializer>();
            string jsonData = @"{ ""Location"": ""Ramallah"",""Humidity"": 85, ""Temperature"": 35 }";
            WeatherData weather=_fixture.Create<WeatherData>();
            mockSerializer.Setup(service=>service.Deserialize<WeatherData>(jsonData)).Returns(weather); 
            SerializerForm jsonSerializer=new SerializerForm(mockSerializer.Object);    

            //Act
            WeatherData expectedData=jsonSerializer.Deserialize<WeatherData>(jsonData); 

            //Assert
            expectedData.Should().NotBeNull();
        }

        [Fact]

        public void Should_ThrowsFileNotFoundException_When_ReadWrongPath()
        {
            //Arrange 
            ConfigurationsFileReader reader = new ConfigurationsFileReader();
            string path = "file.json";

            //Act &Assert
             Assert.Throws<FileNotFoundException>(() => reader.Read(path).GetEnumerator().MoveNext());

        }

        [Fact]
        public void Should_BotsCountEqualsThree_When_FileExists() 
        {
            //Arrange 
            ConfigurationsFileReader reader = new ConfigurationsFileReader();
            string path = "config.json";

            //Act 
            var result = reader.Read(path);

            //Assert
            Assert.Equal(3,result.Count());

        }
    }

}
