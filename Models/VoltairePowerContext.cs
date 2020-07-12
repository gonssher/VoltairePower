using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoltairePower.Models.Weather;

namespace VoltairePower.Models
{
    public class VoltairePowerContext : DbContext
    {
        public VoltairePowerContext(DbContextOptions<VoltairePowerContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<SolarSheetDetail> SolarSheetDetails { get; set; }
        public DbSet<DataGet> LiveDataFeed { get; set; }
        public DbSet<City> WeatherData { get; set; }
        public DbSet<CheckList> CheckLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne<CheckList>(c => c.CheckList)
                .WithOne(cl => cl.Customer)
                .HasForeignKey<CheckList>(cl => cl.CustomerID);
        }
    }
}
