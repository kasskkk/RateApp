using Microsoft.EntityFrameworkCore;
using RateApp.Domain.Entities;
using RateApp.Domain.Interfaces;
using RateApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Infrastructure.DAOs
{
    public class EmployeeDao : GenericDao<Employee>, IEmployeeDao
    {
        public EmployeeDao(ApplicationDbContext context) : base(context)
        {
        }


    }
}
