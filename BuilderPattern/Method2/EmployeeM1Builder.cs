using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public class EmployeeM1Builder
    {
        public EmployeeM1 emp { get; set; }

        public EmployeeM1Builder()
        {
            emp = new EmployeeM1();
        }

        public EmployeeM1Builder SetFullName(string fullname)
        {
            // Validations can be done here
            string[] names = fullname.Split(' ');
            int numberOfNames = names.Length;

            switch (numberOfNames)
            {
                case 2:
                    emp.FirstName = names[0];
                    emp.LastName = names[1];
                    break;
                default:
                    StringBuilder sb = new StringBuilder();
                    
                    for (int i = 0; i < numberOfNames - 1; i++)
                    {
                        sb.Append(names[i]);
                        sb.Append(' ');
                    }

                    emp.FirstName = sb.ToString();
                    emp.LastName = names[numberOfNames - 1];

                    break;
            }

            return this;
        }


        public EmployeeM1Builder SetEmail(string email)
        {
            // Validations can be done here

            emp.Email = email;
            return this;
        }

        public EmployeeM1Builder SetUserName(string userName)
        {
            // Validations can be done here

            emp.Username = userName;
            return this;
        }

        public EmployeeM1 BuildEmployee()
        {
            return emp;
        }
    }
}
