using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoltairePower.Models;
using VoltairePower.Models.OpenWeatherMap;
using VoltairePower.Models.Weather;

namespace VoltairePower.Repositories
{
    public class ForecastRepository : IForecastRepository
    {
        private VoltairePowerContext _context;

        public ForecastRepository(VoltairePowerContext context)
        {
            _context = context;
        }

        WeatherResponse IForecastRepository.GetForecast(string city)
        {
            string IDOWeather = Constants.OPEN_WEATHER_APPID;
            // Connection String
            var client = new RestClient($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&APPID={IDOWeather}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Deserialize the string content into JToken object
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);

                // Deserialize the JToken object into our WeatherResponse Class
                return content.ToObject<WeatherResponse>();
            }

            return null;
        }

        void IForecastRepository.Add(City city) {
            
            if (city != null)
            {
                _context.WeatherData.Add(city);
                _context.SaveChanges();
            }
        }
    }
}
