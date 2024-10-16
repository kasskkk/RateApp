using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RateApp.Domain.Interfaces;

namespace RateApp.Domain.Employee
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        void Test();
    }
}
