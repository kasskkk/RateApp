using Microsoft.EntityFrameworkCore;
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
    public class EmployeeDao : GenericDao<RateApp.Domain.Employee.Employee>, IEmployeeDao
    {
        public EmployeeDao(ApplicationDbContext context) : base(context)
        {
        }
    }
}
