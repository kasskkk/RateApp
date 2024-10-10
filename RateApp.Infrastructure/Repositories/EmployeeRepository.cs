using RateApp.Domain.Entities;
using RateApp.Domain.Interfaces;
using RateApp.Infrastructure.DAOs;
using RateApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Infrastructure.Repositories
{
    // WE DONT USE IT 
    // IF WE WANT GENERAL METHODS FOR ANY REPOSITORY USE THIS INSTEAD OF EMPLOYEEDAO IN EMPLOYEESERVICE 
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly IEmployeeDao _employeeDao;
        public EmployeeRepository(IEmployeeDao employeeDao) : base((GenericDao<Employee>)employeeDao)
        {
            _employeeDao = employeeDao;
        }

        public void Test()
        {
            Console.WriteLine("testowy test");
        }
    }
}

