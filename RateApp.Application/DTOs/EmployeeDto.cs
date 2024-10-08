﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateApp.Application.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public double? Rating { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public EmployeeDto()
        {

        }
    } 
}
