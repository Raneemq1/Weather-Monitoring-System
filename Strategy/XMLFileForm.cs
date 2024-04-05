using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;
using System.Xml.Serialization;

namespace WeatherMonitoringSystem.Strategy
{
    public class XMLFileForm : IFileReader
    {
        public XMLFileForm() { }
        public WeatherData Read(string data)
        {
            WeatherData weather = Deserialize<WeatherData>(data);
            return weather;
        }

        public T Deserialize<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }

}