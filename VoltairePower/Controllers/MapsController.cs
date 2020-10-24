using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoltairePower.Models;

namespace VoltairePower.Controllers
{
    public class MapsController : Controller
    {
        private readonly VoltairePowerContext _context;

        public MapsController(VoltairePowerContext context)
        {
            _context = context;
        }


        // GET: MapsController
        public ActionResult Index()
        {
            return View();
        }





        public async Task<IActionResult> Map(int? id)
        {
            id = (int)HttpContext.Session.GetInt32("CustomerId");

            if (id == null)
            {
                return RedirectToAction("NotFound", "UnplannedEvents");
            }

            var solarSheetDetails = _context.SolarSheetDetails.FirstOrDefault(m => m.CustomerID == id);
            var customerData = _context.Customers.FirstOrDefault(m => m.Id == id);

            if (solarSheetDetails == null)
            {
                return RedirectToAction("NotFound", "UnplannedEvents");
            }

            return View(solarSheetDetails);

        }



        // GET: MapsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MapsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MapsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MapsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MapsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MapsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MapsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
