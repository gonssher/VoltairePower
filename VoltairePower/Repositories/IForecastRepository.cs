using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoltairePower.Models.OpenWeatherMap;
using VoltairePower.Models.Weather;

namespace VoltairePower.Repositories
{
    public interface IForecastRepository
    {
        WeatherResponse GetForecast(string city);
        void Add(City city);
    }
}
