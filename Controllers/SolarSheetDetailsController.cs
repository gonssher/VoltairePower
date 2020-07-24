using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoltairePower.Models;

namespace VoltairePower.Controllers
{
    public class SolarSheetDetailsController : Controller
    {
        private readonly VoltairePowerContext _context;

        public SolarSheetDetailsController(VoltairePowerContext context)
        {
            _context = context;
        }

        // GET: SolarSheetDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.SolarSheetDetails.ToListAsync());
        }

        // GET: SolarSheetDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solarSheetDetail = await _context.SolarSheetDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solarSheetDetail == null)
            {
                return NotFound();
            }

            return View(solarSheetDetail);
        }

        // GET: SolarSheetDetails/Create
        public IActionResult Create()
        {
            int customerId = Convert.ToInt32(HttpContext.Session.GetInt32("CustomerId"));
            Customer customer = (from u in _context.Customers where u.Id == customerId select u).First<Customer>();

           SolarSheetDetail solarSheetDetail = (from l in _context.SolarSheetDetails where l.CustomerID == customerId select l).FirstOrDefault<SolarSheetDetail>();

            if (solarSheetDetail != null)
            {
                return RedirectToAction("Edit", new { @id = solarSheetDetail.Id });
            }

            return View();
        }

        // POST: SolarSheetDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SolarSize,ArrayLocation,ArrayLocationLong,Type,NumberofInverters,NumberOfSolarStrings,SolarModuleMake,SolarModulePwr,ModuleOpenShortCircuit,ModuleShortCircuit,ModulePerSeries,ModuleTempCoeff,InverterSize,DcInput,MaxDc,PeakPwrTv,PeakInvEff,AcOpVolt,AcVolt,AcFreqNorminal,MaxContinuousOC,PowerFact,WireGPerStr,TypeofWire,LengthOfString")] SolarSheetDetail solarSheetDetail)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int customerId = Convert.ToInt32(HttpContext.Session.GetInt32("CustomerId"));

                    Customer customer = (from u in _context.Customers where u.Id == customerId select u).First<Customer>();
                    customer.IsCompletedReg = true;

                    solarSheetDetail.Customer = customer;

                    _context.Add(solarSheetDetail);
                    _context.Update(customer);

                    await _context.SaveChangesAsync();

                    ViewBag.Message = "Your solar sheet information has been registered!";

                    return View("Confirm");

                }
                catch
                {
                    ViewBag.Message = "An error has occurred. Please try again!";

                    return View(solarSheetDetail);
                }
            }
            return View(solarSheetDetail);
        }

        // GET: SolarSheetDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solarSheetDetail = await _context.SolarSheetDetails.FindAsync(id);
            if (solarSheetDetail == null)
            {
                return NotFound();
            }
            return View(solarSheetDetail);
        }

        // POST: SolarSheetDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SolarSize,ArrayLocation,ArrayLocationLong,Type,NumberofInverters,NumberOfSolarStrings,SolarModuleMake,SolarModulePwr,ModuleOpenShortCircuit,ModuleShortCircuit,ModulePerSeries,ModuleTempCoeff,InverterSize,DcInput,MaxDc,PeakPwrTv,PeakInvEff,AcOpVolt,AcVolt,AcFreqNorminal,MaxContinuousOC,PowerFact,WireGPerStr,TypeofWire,LengthOfString,CustomerID")] SolarSheetDetail solarSheetDetail)
        {
            if (id != solarSheetDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solarSheetDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolarSheetDetailExists(solarSheetDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("SearchCity", "Weather");
            }
            return View(solarSheetDetail);
        }

        // GET: SolarSheetDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solarSheetDetail = await _context.SolarSheetDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solarSheetDetail == null)
            {
                return NotFound();
            }

            return View(solarSheetDetail);
        }

        // POST: SolarSheetDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solarSheetDetail = await _context.SolarSheetDetails.FindAsync(id);
            _context.SolarSheetDetails.Remove(solarSheetDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolarSheetDetailExists(int id)
        {
            return _context.SolarSheetDetails.Any(e => e.Id == id);
        }
    }
}
