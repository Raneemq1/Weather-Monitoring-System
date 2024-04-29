using System.Xml.Serialization;


namespace WeatherMonitoringSystem.Serilaizers
{
    public class XMLSerializer : ISerializer
    {
        public T? Deserialize<T>(string data)
        {
            try
            {
                return DeserializeXMLData<T>(data);
            }
            catch
            {
                return default;
            }

        }

        public T? DeserializeXMLData<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }

}