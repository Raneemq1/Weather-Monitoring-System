namespace WeatherMonitoringSystem.Serilaizers
{
    public class SerializerForm
    {
        private ISerializer reader;

        public SerializerForm(ISerializer reader)
        {
            this.reader = reader;
        }

        public T? Deserialize<T>(string data)
        {
                return reader.Deserialize<T>(data);

        }
    }
}
