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
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly EmployeeDao _employeeDao;
        public EmployeeRepository(EmployeeDao employeeDao) : base(employeeDao)
        {
            _employeeDao = employeeDao;
        }
    }
}

