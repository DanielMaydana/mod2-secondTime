using System.Collections.Generic;
using Common;
namespace Data
{
    public class FirstContext : IContext<WeatherData>
    {
        List<WeatherData> internalValues = new List<WeatherData>();
        public List<WeatherData> GetAll()
        {
            internalValues.Add(new WeatherData("rainy"));
            internalValues.Add(new WeatherData("cloudy"));
            internalValues.Add(new WeatherData("sunny"));
            return internalValues;
        }
    }
}
