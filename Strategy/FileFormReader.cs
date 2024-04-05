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
           return reader.Read(data);
        }
    }
}
