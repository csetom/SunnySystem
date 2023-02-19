using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SunnySystem.Data;
using SunnySystem.Data.Models;

namespace SunnySystem.Data
{
    
     
    public class SunnySystemDBContext : DbContext
    {
       private const string DefaultConnStr="Server=dumbo.db.elephantsql.com;Database=lnghydvr;User Id=lnghydvr;Password=62M5jDVpzFHriCJFUSH57p46JD3eWj9R;Port=5432";

       public SunnySystemDBContext()
            : base()
        {
            this.Database.EnsureCreated();
        }

        public SunnySystemDBContext(DbContextOptions<SunnySystemDBContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
            {
                throw new ArgumentNullException(nameof(optionsBuilder));
            }

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseNpgsql(DefaultConnStr);
            }
        }


    }
    
}