using Common;
using Data;
using System.Linq;
using Recomendation;
namespace WeatherBusiness
{
    public class Forecast
    {
        private IContext<WeatherData> context;
        public Forecast(IContext<WeatherData> context)
        {
            this.context = context;
        }

        public Forecast()
        {
            context = null;
        }

        public WeatherRecomendation GetRecomendation()
        {
            this.context = GetContext();
            WeatherData a = context.GetAll().FirstOrDefault();
            WeatherRecomendation result = BuildResult(a);
            return result;
        }

        private WeatherRecomendation BuildResult(WeatherData a)
        {
            if (a == null) return new WeatherRecomendation("no data");

            string aux = "";
            switch (a.value) {
                case ("sunny"):
                    aux = "use suncream";
                    break;
                case ("cloudy"):
                    aux = "use sweater";
                    break;
                case ("rainy"):
                    aux = "use umbrella";
                    break;
                default:
                    aux = "no data";
                    break;
            }
            return new WeatherRecomendation(aux);
        }

        public IContext<WeatherData> GetContext()
        {
            return this.context == null ? new FirstContext() : this.context;
        }
    }
}
