using BuilderPattern.Method2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method3
{
    public abstract class EmployeeM2Builder : IEmployeeM2Builder
    {
        protected EmployeeM2 employeeM2;
        protected IEmployeeM2Builder _instance;
        public EmployeeM2Builder()
        {
            employeeM2 = new EmployeeM2();
        }

        public virtual IEmployeeM2Builder SetEmail(string email)
        {
            employeeM2.Email = email;

            return this;
        }

        public virtual IEmployeeM2Builder SetFullName(string fullName)
        {
            string[] names = fullName.Split(' ');
            int numberOfNames = names.Length;

            switch (numberOfNames)
            {
                case 2:
                    employeeM2.FirstName = names[0];
                    employeeM2.LastName = names[1];
                    break;
                default:
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < numberOfNames - 1; i++)
                    {
                        sb.Append(names[i]);
                        sb.Append(' ');
                    }

                    employeeM2.FirstName = sb.ToString();
                    employeeM2.LastName = names[numberOfNames - 1];

                    break;
            }

            return this;
        }

        public virtual IEmployeeM2Builder SetUserName(string userName)
        {
            employeeM2.Username = userName;

            return this;
        }

        public EmployeeM2 BuildEmployee()
        {
            return employeeM2;
        }
    }
}
