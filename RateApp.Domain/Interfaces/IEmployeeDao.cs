using RateApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Domain.Interfaces
{
    public interface IEmployeeDao
    {
        void Create(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
    }
}
