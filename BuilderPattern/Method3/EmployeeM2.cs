﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method3
{
    public class EmployeeM2
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Username})";            
        }

    }

    public enum EmployeeType
    {
        External = 0,
        Internal = 1
    }
}
