using System;
using System.Collections.Generic;
using System.Text;
using Common;
namespace Data
{
    public class FirstContext : IContext<WeatherData>
    {
        List<WeatherData> internalValues = new List<WeatherData>();
        public List<WeatherData> GetAll()
        {
            internalValues.Add(new WeatherData("sunny"));
            internalValues.Add(new WeatherData("cloudy"));
            internalValues.Add(new WeatherData("rainy"));
            return internalValues;
        }
    }
}
