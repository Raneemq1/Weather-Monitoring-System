using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherMonitoringSystem.model;

namespace WeatherMonitoringSystem.Strategy
{
    public interface IFileReader
    {
        WeatherData Read(string data);
    }
}
