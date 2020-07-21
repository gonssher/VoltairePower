using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoltairePower.Models;

namespace VoltairePower.Controllers
{
    public class ChartDatasController : Controller
    {
        private readonly VoltairePowerContext _context;

        public ChartDatasController(VoltairePowerContext context)
        {
            _context = context;
        }

        // GET: ChartDatas
        public async Task<IActionResult> LineChart()
        {
            return View();
        }

        // GET: ChartDatas/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartData = await _context.ChartData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chartData == null)
            {
                return NotFound();
            }

            return View(chartData);
        }

        // GET: ChartDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChartDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TimeStamp,Voltage,TranslatedVoltage")] ChartData chartData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chartData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chartData);
        }

        // GET: ChartDatas/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartData = await _context.ChartData.FindAsync(id);
            if (chartData == null)
            {
                return NotFound();
            }
            return View(chartData);
        }

        // POST: ChartDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double id, [Bind("Id,TimeStamp,Voltage,TranslatedVoltage")] ChartData chartData)
        {
            //if (id != chartData.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(chartData);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!ChartDataExists(chartData.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            return View(chartData);
        }

        // GET: ChartDatas/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chartData = await _context.ChartData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (chartData == null)
            {
                return NotFound();
            }

            return View(chartData);
        }

        // POST: ChartDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double id)
        {
            var chartData = await _context.ChartData.FindAsync(id);
            _context.ChartData.Remove(chartData);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChartDataExists(double id)
        {
            return _context.ChartData.Any(e => e.Id == id);
        }
    }
}
