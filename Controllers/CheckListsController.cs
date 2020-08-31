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
    public class CheckListsController : Controller
    {
        private readonly VoltairePowerContext _context;

        public CheckListsController(VoltairePowerContext context)
        {
            _context = context;
        }

        // GET: CheckLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.CheckLists.ToListAsync());
        }

        // GET: CheckLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkList = await _context.CheckLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (checkList == null)
            {
                return NotFound();
            }

            return View(checkList);
        }

        // GET: CheckLists/Create
        public IActionResult Create()
        {
            int customerId = Convert.ToInt32(HttpContext.Session.GetInt32("CustomerId"));
            Customer customer = (from u in _context.Customers where u.Id == customerId select u).First<Customer>();

            CheckList checkList = (from l in _context.CheckLists where l.CustomerID == customerId select l).FirstOrDefault<CheckList>();

            if (checkList != null) {
                return RedirectToAction("Edit", new { @id = checkList.Id });
            }

            return View();
        }

        // POST: CheckLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ac_out,energy_prod,inspect_panel,shading_issue,panel_clean,inspect_array_mount,array_tilt,charge_ctrl_settings,battery_test,clean_elect_equipment,monitor_volt_current,Mac_out,Menergy_prod,Minspect_panel,Mshading_issue,Mpanel_clean,Minspect_array_mount,Marray_tilt,Mcharge_ctrl_settings,Mbattery_test,Mclean_elect_equipment,Mmonitor_volt_current,Sac_out,Senergy_prod,Sinspect_panel,Sshading_issue,Spanel_clean,Sinspect_array_mount,Sarray_tilt,Scharge_ctrl_settings,Sbattery_test,Sclean_elect_equipment,Smonitor_volt_current")] CheckList checkList)
        {
            if (ModelState.IsValid)
            {
                int customerId = Convert.ToInt32(HttpContext.Session.GetInt32("CustomerId"));
                Customer customer = (from u in _context.Customers where u.Id == customerId select u).First<Customer>();

                checkList.Customer = customer;

                _context.Add(checkList);
                await _context.SaveChangesAsync();
                return RedirectToAction("Mainpage", "Home");
            }
            return View(checkList);
        }

        // GET: CheckLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkList = await _context.CheckLists.FindAsync(id);
            if (checkList == null)
            {
                return NotFound();
            }
            return View(checkList);
        }

        // POST: CheckLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ac_out,energy_prod,inspect_panel,shading_issue,panel_clean,inspect_array_mount,array_tilt,charge_ctrl_settings,battery_test,clean_elect_equipment,monitor_volt_current,Mac_out,Menergy_prod,Minspect_panel,Mshading_issue,Mpanel_clean,Minspect_array_mount,Marray_tilt,Mcharge_ctrl_settings,Mbattery_test,Mclean_elect_equipment,Mmonitor_volt_current,Sac_out,Senergy_prod,Sinspect_panel,Sshading_issue,Spanel_clean,Sinspect_array_mount,Sarray_tilt,Scharge_ctrl_settings,Sbattery_test,Sclean_elect_equipment,Smonitor_volt_current,CustomerID")] CheckList checkList)
        {
            if (id != checkList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checkList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CheckListExists(checkList.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("MainPage", "Home");
            }
            return View(checkList);
        }

        // GET: CheckLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checkList = await _context.CheckLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (checkList == null)
            {
                return NotFound();
            }

            return View(checkList);
        }

        // POST: CheckLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var checkList = await _context.CheckLists.FindAsync(id);
            _context.CheckLists.Remove(checkList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckListExists(int id)
        {
            return _context.CheckLists.Any(e => e.Id == id);
        }
    }
}
