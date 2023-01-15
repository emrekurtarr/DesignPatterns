using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method3
{
    public class InternalEmployeeBuilder : EmployeeM2Builder
    {

        public override IEmployeeM2Builder SetEmail(string email)
        {
            // Some company logic here 
            // For example company name is Inveon, email must be ends with inveon.com

            string[] emailParts = email.Split('@');
            string firstPart = "";

            if (emailParts.Length >= 2)
                firstPart = emailParts[0];

            employeeM2.Email = firstPart + "@inveon.com";

            return this;
        }

    }
}
