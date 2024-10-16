using Microsoft.EntityFrameworkCore;
using RateApp.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<RateApp.Domain.Employee.Employee> Employees { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=RateApp;Username=postgres;Password=1234");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Dodatkowe konfiguracje
        }
    }
}