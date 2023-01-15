using BuilderPattern.Method2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method3
{
    public interface IEmployeeM2Builder
    {
        public IEmployeeM2Builder SetFullName(string fullName);
        public IEmployeeM2Builder SetEmail(string email);
        public IEmployeeM2Builder SetUserName(string userName);
        public EmployeeM2 BuildEmployee();

    }
}
