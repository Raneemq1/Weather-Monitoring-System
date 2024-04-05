using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem.Strategy
{
    public class FileFormReader
    {
        private IFileReader reader;

        public FileFormReader(IFileReader reader)
        {
            this.reader = reader;
        }

        public void Read(string filePath)
        {
            reader.Read(filePath);
        }
    }
}
