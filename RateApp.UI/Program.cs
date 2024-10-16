using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RateApp.Application.Employee;
using RateApp.Domain.Employee;
using RateApp.Infrastructure.Data;
using RateApp.Infrastructure.Employee;
using RateApp.Ui.UI;

namespace RateApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //APPSETTINGS INSTEAD OF USENPGSQL
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options =>
                    options.UseNpgsql("Host=localhost;Database=RateApp;Username=postgres;Password=1234"))
                .AddScoped<IEmployeeDao, EmployeeDao>()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
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
