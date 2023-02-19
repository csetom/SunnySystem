using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SunnySystem.Data;
using SunnySystem.Data.Models;

namespace SunnySystem.Data
{
    public class SunnySystemDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(ConnStr.Get());
    }
    
}