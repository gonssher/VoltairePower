using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoltairePower.Models.Data_Layer;
using VoltairePower.Models.Weather;
using VoltairePower.Models;
using VoltairePower.Models.Graph_Tables;

namespace VoltairePower.Models
{
    public class VoltairePowerContext : DbContext
    {
        public VoltairePowerContext()
        {
        }

        public  VoltairePowerContext(DbContextOptions<VoltairePowerContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<SolarSheetDetail> SolarSheetDetails { get; set; }
        public DbSet<LiveFeedData> LiveDataFeed { get; set; }
        public DbSet<City> WeatherData { get; set; }
        public DbSet<CheckList> CheckLists { get; set; }
        public DbSet<PopulatingLineGraph> LineChart { get; set;}

        public DbSet<PredictedActual> PredictedData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne<CheckList>(c => c.CheckList)
                .WithOne(cl => cl.Customer)
                .HasForeignKey<CheckList>(cl => cl.CustomerID);
        }
        public DbSet<VoltairePower.Models.ChartData> ChartData { get; set; }
    }
}
