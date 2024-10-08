using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RateApp.Application.DTOs;
using RateApp.Application.Interfaces;
using RateApp.Application.Services;
using RateApp.Domain.Interfaces;
using RateApp.Infrastructure.DAOs;
using RateApp.Infrastructure.Data;
using RateApp.Ui.UI;
using System.Security.Authentication.ExtendedProtection;

namespace RateApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
    .AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql("Host=localhost;Database=RateApp;Username=postgres;Password=1234"))
    .AddScoped<IEmployeeDao, EmployeeDao>()    
    .AddScoped<IEmployeeService, EmployeeService>()  
    .BuildServiceProvider();

            var employeeService = serviceProvider.GetService<IEmployeeService>();
            if (employeeService == null)
            {
                Console.WriteLine("Employee service is not registered.");
                return;
            }

            UserInterface app = new UserInterface(employeeService);
            app.Run();
        }
    }
}
