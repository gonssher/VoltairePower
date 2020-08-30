using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoltairePower.Models;

namespace VoltairePower.Controllers
{
    public class UnplaanedEventsController : Controller
    {
        private readonly VoltairePowerContext _context;

        public UnplaanedEventsController(VoltairePowerContext context)
        {
            _context = context;
        }

        // GET: UnplaanedEvents
        public async Task<IActionResult> Index()
        {

            return View(await _context.UnplannedEvent.ToListAsync());

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
                return RedirectToAction("NotFound", "UnplaanedEvents");
            }

                var unplaanedEvent = await _context.UnplannedEvent
                    .FirstOrDefaultAsync(m => m.CustomerID == id);

            if (unplaanedEvent == null)
            {
                return RedirectToAction("NotFound", "UnplaanedEvents");
            }

            return View(unplaanedEvent);

        }



        // GET: UnplaanedEvents/Details/5
        public async Task<IActionResult> Details (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var unplaanedEvent = await _context.UnplannedEvent
                .FirstOrDefaultAsync(m => m.Id == id );
            if (unplaanedEvent == null)
            {
                return NotFound();
            }

            return View(unplaanedEvent);
        }

        // GET: UnplaanedEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnplaanedEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventDescription,EventCause,SelfActionTaken,Result")] UnplaanedEvent unplaanedEvent)
        {

            if (ModelState.IsValid)
            {
                int customerId = Convert.ToInt32(HttpContext.Session.GetInt32("CustomerId"));
                Customer customer = (from u in _context.Customers where u.Id == customerId select u).First<Customer>();
                unplaanedEvent.Customer = customer;
                _context.Add(unplaanedEvent);
                await _context.SaveChangesAsync();
                //return RedirectToAction("Index", "Unplaanedevents");
                return RedirectToAction("Mainpage", "Home");
            }
            return View(unplaanedEvent);
        }

        // GET: UnplaanedEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unplaanedEvent = await _context.UnplannedEvent.FindAsync(id);
            if (unplaanedEvent == null)
            {
                return NotFound();
            }
            return View(unplaanedEvent);
        }

        // POST: UnplaanedEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventDescription,EventCause,SelfActionTaken,Result")] UnplaanedEvent unplaanedEvent)
        {
            if (id != unplaanedEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unplaanedEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnplaanedEventExists(unplaanedEvent.Id))
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
            return View(unplaanedEvent);
        }

        // GET: UnplaanedEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unplaanedEvent = await _context.UnplannedEvent
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unplaanedEvent == null)
            {
                return NotFound();
            }

            return View(unplaanedEvent);
        }

        // POST: UnplaanedEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unplaanedEvent = await _context.UnplannedEvent.FindAsync(id);
            _context.UnplannedEvent.Remove(unplaanedEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnplaanedEventExists(int id)
        {
            return _context.UnplannedEvent.Any(e => e.Id == id);
        }
    }
}
