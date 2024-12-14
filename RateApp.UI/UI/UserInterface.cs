using RateApp.Application.Employee;
using RateApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Ui.UI
{
    public class UserInterface
    {
        private readonly IEmployeeService _employeeService;
        public UserInterface(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public void Run()
        {
            int choice, id, age;
            double rating;
            string name, firstName, lastName, email, phoneNumber;
            do
            {
                Console.Clear();
                Console.WriteLine("---RATING EMPLOYEE APP---");

                Console.WriteLine("Chose option \n1-Create employee \n2-Update employee \n3-Delete employee \n4-Get by Id employee \n5-Display all employees \n6-Update rating of employee");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid input choose from 1-6");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter rating");
                        while (!double.TryParse(Console.ReadLine(), out rating))
                        {
                            Console.WriteLine("Invalid input");
                        }

                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter FIRSTname: ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter lastName: ");
                        lastName = Console.ReadLine();
                        Console.Write("Enter age: ");
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Invalid input");
                        }
                        Console.Write("Enter email: ");
                        email = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        phoneNumber = Console.ReadLine();

                        var employeeDto = new EmployeeDto
                        {
                            Rating = rating,
                            Name = name,
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            Email = email,
                            PhoneNumber = phoneNumber
                        };

                        _employeeService.CreateEmployee(employeeDto);
                        break;
                    case 2:
                        Console.WriteLine("Enter employee id: ");
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Invalid input");
                        }

                        Console.WriteLine("Enter rating: ");
                        while (!double.TryParse(Console.ReadLine(), out rating))
                        {
                            Console.WriteLine("Invalid input");
                        }

                        Console.Write("Enter name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter firstName: ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter lastName: ");
                        lastName = Console.ReadLine();
                        Console.Write("Enter age: ");
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Invalid input");
                        }

                        Console.Write("Enter email: ");
                        email = Console.ReadLine();
                        Console.Write("Enter phone: ");
                        phoneNumber = Console.ReadLine();

                        employeeDto = new EmployeeDto
                        {
                            Id = id,
                            Rating = rating,
                            Name = name,
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            Email = email,
                            PhoneNumber = phoneNumber
                        };

                        _employeeService.UpdateEmployee(employeeDto);
                        break;
                    case 3:
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Invalid input");
                        }
                        _employeeService.DeleteEmployee(id);
                        break;
                    case 4:
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Invalid input");
                        }
                        _employeeService.GetEmployeeById(id);
                        break;
                    case 5:
                        var employees = _employeeService.GetAllEmployees();
                        foreach (var item in employees)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 6:
                        _employeeService.Test();
                        break;
                    default:
                        Console.WriteLine("Please check input");
                        break;
                }

            } while (true);
        }
    }
}
