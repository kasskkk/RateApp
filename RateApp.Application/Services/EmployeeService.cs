using RateApp.Application.DTOs;
using RateApp.Application.Interfaces;
using RateApp.Domain.Entities;
using RateApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Application.Services
{

    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeDao _employeeDao;

        public EmployeeService(IEmployeeDao employeeDao)
        {
            _employeeDao = employeeDao ?? throw new ArgumentNullException(nameof(employeeDao));
        }

        public void CreateEmployee(EmployeeDto employeeDto)
        {
            var employee = new Employee()
            {
                Name = employeeDto.Name,
                Rating = employeeDto.Rating,
            };

            _employeeDao.Create(employee);
        }

        public void DeleteEmployee(int id)
        {
            _employeeDao.Delete(id);
        }

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var employees = _employeeDao.GetAll();

            if (employees == null)
            {
                throw new ArgumentException($"Employees not found");
            }

            return employees.Select(x => new EmployeeDto()
            {
                Id = x.Id,
                Name = x.Name,
                Rating = x.Rating,
            });
        }

        public EmployeeDto GetEmployeeById(int id)
        {
            var employee = _employeeDao.GetById(id);

            if (employee == null)
            {
                throw new ArgumentException($"Employee with {employee.Id} not found");
            }

            return new EmployeeDto
            {
                Id= employee.Id,
                Name = employee.Name,
                Rating = employee.Rating,
            };
        }

        public void UpdateEmployee(EmployeeDto employeeDto)
        {
            var employee = new Employee()
            {
                Id = employeeDto.Id ,
                Name = employeeDto.Name,
                Rating = employeeDto.Rating,
            };

            _employeeDao.Update(employee);
        }

        public void UpdateRatingEmployee(EmployeeDto employeeDto)
        {
            if (employeeDto.Rating < 0)
            {
                throw new ArgumentOutOfRangeException("Rating must be equal or greater than 0");
            }

            var employee = _employeeDao.GetById(employeeDto.Id);
            if (employee == null)
            {
                throw new ArgumentException($"Employee with {employeeDto.Id} not found");
            }

            employee.Rating = employeeDto.Rating;
            _employeeDao.Update(employee);
        }
    }
}
