using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Strategy
{
    public class FileFormReader
    {
        private IFileReader reader;

        public FileFormReader(IFileReader reader)
        {
            this.reader = reader;
        }

        public WeatherData Read(string data)
        {
            try
            {
                return reader.Read(data);
            }
            catch
            {
                throw new Exception("Faild to load data,Invaild Input type");
            }
        }
    }
}
