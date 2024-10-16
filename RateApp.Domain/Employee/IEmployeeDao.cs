using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Domain.Employee
{
    // WE DONT NEED THIS CLASS WE CAN USE EMPLOYEEREPOSITORY INSTEAD
    public interface IEmployeeDao
    {
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
    }
}
