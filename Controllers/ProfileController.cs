using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VoltairePower.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VoltairePower.Controllers
{
    public class ProfileController : Controller
    {
        private readonly VoltairePowerContext _context;

        public ProfileController(VoltairePowerContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
           int id = (int)HttpContext.Session.GetInt32("CustomerId");
           Customer user = await _context.Customers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile([Bind("Id,CustName,Mobile,Email,UnitNumber,StreetNumber,StreetName,PostalCode,Password")] Models.Customer profile)
        {
            ModelState.Remove("ConfirmPassword");
            profile.ConfirmPassword = profile.Password;
            if (ModelState.IsValid)
            {
                try
                {
                    int id = (int)HttpContext.Session.GetInt32("CustomerId");
                    profile.Id = id;
                    _context.Update(profile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                }
                HttpContext.Session.SetString("CustomerName", profile.CustName);
                return RedirectToAction("Profile","Profile");               
            }
            return View(profile);
        }
    }
}
