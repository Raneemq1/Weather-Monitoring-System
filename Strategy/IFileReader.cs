using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem.Strategy
{
    public interface IFileReader
    {
        void Read(string pathFile);
    }
}
