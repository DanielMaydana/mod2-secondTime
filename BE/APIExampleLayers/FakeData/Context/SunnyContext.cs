using System;
using System.Collections.Generic;
using Common;
namespace FakeData.Context
{
    public class SunnyContext : IContext<WeatherData>
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
