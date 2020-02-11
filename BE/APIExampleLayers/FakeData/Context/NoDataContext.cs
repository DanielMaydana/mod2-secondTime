using System.Collections.Generic;
using Common;
namespace FakeData.Context
{
    public class NoDataContext : IContext<WeatherData>
    {
        List<WeatherData> internalValues = new List<WeatherData>();
        public List<WeatherData> GetAll()
        {
            return internalValues;
        }
    }
}
