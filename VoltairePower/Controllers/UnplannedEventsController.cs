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
    public class UnplannedEventsController : Controller
    {
        private readonly VoltairePowerContext _context;

        public UnplannedEventsController(VoltairePowerContext context)
        {
            _context = context;
        }

        // GET: UnplannedEvents
        public async Task<IActionResult> Index()
        {
            var voltairePowerContext = _context.UnplannedEvent.Include(u => u.Customer);
            return View(await voltairePowerContext.ToListAsync());
        }

        // GET: UnplannedEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unplannedEvent = await _context.UnplannedEvent
                .Include(u => u.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unplannedEvent == null)
            {
                return NotFound();
            }

            return View(unplannedEvent);
        }

        // GET: UnplannedEvents/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers, "Id", "ConfirmPassword");
            return View();
        }


        public IActionResult NotFound()

        {
            return View();
        }



        public async Task<IActionResult> CustomerReports(int? id)
        {
            id = (int)HttpContext.Session.GetInt32("CustomerId");

            if (id == null)
            {
                return RedirectToAction("Create", "UnplannedEvents");
            }

            var unplaanedEvent = _context.UnplannedEvent.Where(m => m.CustomerID == id).ToList();

            if (unplaanedEvent == null)
            {
                return RedirectToAction("Create", "UnplannedEvents");
            }

            return View(unplaanedEvent);

        }



        // POST: UnplannedEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventDescription,EventCause,SelfActionTaken,Result,CustomerID")] UnplannedEvent unplannedEvent)
        {
   
            if (ModelState.IsValid)
            {
                int customerId = Convert.ToInt32(HttpContext.Session.GetInt32("CustomerId"));
                Customer customer = (from u in _context.Customers where u.Id == customerId select u).First<Customer>();
                unplannedEvent.Customer = customer;
                _context.Add(unplannedEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Mainpage", "Home");
            }
            return View(unplannedEvent);
        }

        // GET: UnplannedEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unplannedEvent = await _context.UnplannedEvent.FindAsync(id);
            if (unplannedEvent == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customers, "Id", "ConfirmPassword", unplannedEvent.CustomerID);
            return View(unplannedEvent);
        }

        // POST: UnplannedEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventDescription,EventCause,SelfActionTaken,Result,CustomerID")] UnplannedEvent unplannedEvent)
        {
            if (id != unplannedEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unplannedEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnplannedEventExists(unplannedEvent.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customers, "Id", "ConfirmPassword", unplannedEvent.CustomerID);
            return View(unplannedEvent);
        }

        // GET: UnplannedEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unplannedEvent = await _context.UnplannedEvent
                .Include(u => u.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unplannedEvent == null)
            {
                return NotFound();
            }

            return View(unplannedEvent);
        }

        // POST: UnplannedEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unplannedEvent = await _context.UnplannedEvent.FindAsync(id);
            _context.UnplannedEvent.Remove(unplannedEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnplannedEventExists(int id)
        {
            return _context.UnplannedEvent.Any(e => e.Id == id);
        }
    }
}
