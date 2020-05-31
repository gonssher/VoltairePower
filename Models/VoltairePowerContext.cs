using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoltairePower.Models
{
    public class VoltairePowerContext : DbContext
    {
        public VoltairePowerContext(DbContextOptions<VoltairePowerContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<SolarSheetDetail> SolarSheetDetails { get; set; }
        public DbSet<DataGet> LiveDataFeed { get; set; }
    }
}
