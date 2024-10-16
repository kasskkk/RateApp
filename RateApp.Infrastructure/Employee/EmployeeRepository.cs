using RateApp.Domain.Employee;
using RateApp.Infrastructure.Data;
using RateApp.Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Infrastructure.Employee
{
    // WE DONT USE IT 
    // IF WE WANT GENERAL METHODS FOR ANY REPOSITORY USE THIS INSTEAD OF EMPLOYEEDAO IN EMPLOYEESERVICE 
    public class EmployeeRepository : Repository<RateApp.Domain.Employee.Employee>, IEmployeeRepository
    {
        private readonly IEmployeeDao _employeeDao;
        public EmployeeRepository(IEmployeeDao employeeDao) : base((GenericDao<RateApp.Domain.Employee.Employee>)employeeDao)
        {
            _employeeDao = employeeDao;
        }

        public void Test()
        {
            Console.WriteLine("testowy test");
        }
    }
}

