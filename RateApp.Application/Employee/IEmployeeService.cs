using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Application.Employee
{
    public interface IEmployeeService
    {

        void UpdateRatingEmployee(EmployeeDto employeeDto);
        void CreateEmployee(EmployeeDto employee);
        void UpdateEmployee(EmployeeDto employee);
        void DeleteEmployee(int id);
        EmployeeDto GetEmployeeById(int id);
        IEnumerable<EmployeeDto> GetAllEmployees();
        void Test();
    }
}
