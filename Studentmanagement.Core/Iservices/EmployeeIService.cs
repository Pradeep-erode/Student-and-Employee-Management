using Studentmanagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement.Core.Iservices
{
    public interface EmployeeIService
    {
        int Admincheck(Employeelogin employeelogin);

        IEnumerable<Employeemanagemet> Dashboard();

        void Create(Employeemanagemet employeedetail);

        public List<Departmentlist> Getdepartmet();

        public Employeemanagemet Edit(int id);

        void Delete(int studentid);

        Employeemanagemet Details(int studentid);
    }
}
