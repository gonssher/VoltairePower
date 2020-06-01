using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoltairePower.Models.Weather;
//using VoltairePower.OpenWeatherMapModels;
//using VoltairePower.Repositories;
using Microsoft.AspNetCore.Mvc;
using VoltairePower.Repositories;
using VoltairePower.Models.OpenWeatherMap;

namespace VoltairePower.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IForecastRepository _forecastRepository;

        // Dependency Injection
        public WeatherController(IForecastRepository weatherRepo)
        {
            _forecastRepository = weatherRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: Weather/SearchCity
        public IActionResult SearchCity()
        {
            var viewModel = new SearchCity();
            return View(viewModel);
        }

        // POST: Weather/SearchCity
        [HttpPost]
        public IActionResult SearchCity(SearchCity model)
        {
            // If the model is valid, consume the Weather API to bring the data of the city
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "Weather", new { city = model.CityName });
            }
            return View(model);
        }

        // GET: Weather/City
        public IActionResult City(string city)
        {
            WeatherResponse weatherResponse = _forecastRepository.GetForecast(city);
            City viewModel = new City();

       
   
            if (weatherResponse != null)
            {
                viewModel.Name = weatherResponse.Name;
                viewModel.Humidity = weatherResponse.Main.Humidity;
                viewModel.Pressure = weatherResponse.Main.Pressure;
                viewModel.Temp = weatherResponse.Main.Temp;
                viewModel.Weather = weatherResponse.Weather[0].Main;
                viewModel.Wind = weatherResponse.Wind.Speed;
                viewModel.Clouds = weatherResponse.Clouds.All;
                viewModel.Sunshine = weatherResponse.Sys.Sunshine;
            }
            return View(viewModel);
        }
    }
}