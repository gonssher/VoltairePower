using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VoltairePower.Controllers
{
    public class ChartData : Controller
    {
        public IActionResult LineChart()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
