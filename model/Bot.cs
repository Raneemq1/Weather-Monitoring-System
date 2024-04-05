﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitoringSystem.model
{
    public class Bot
    {
        public bool IsEnabled { get; set; }
        public string Message { get; set; }
        public double ThresoldValue { get; set; }

        public Bot(bool isEnabled, string message, double thresoldValue)
        {
            IsEnabled = isEnabled;
            Message = message;
            ThresoldValue = thresoldValue;
        }
    }
}
