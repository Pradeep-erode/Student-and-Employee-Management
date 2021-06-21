using Studentmanagement.Core.IRepository;
using Studentmanagement.Core.Iservices;
using Studentmanagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Studentmanagement.Services.Services
{
    public class EmployeeServices: EmployeeIService
    {
        private readonly EmployeeIRepository _employeerepo;
        public EmployeeServices(EmployeeIRepository emplo)
        {
            _employeerepo = emplo;
        }
        public int Admincheck(Employeelogin employeelogin)
        {
            return _employeerepo.Admincheck(employeelogin);
        }
        public IEnumerable<Employeemanagemet> Dashboard()
        {
            return _employeerepo.Dashboard();
        }
        public void Create(Employeemanagemet employeedetail)
        {
            _employeerepo.Create(employeedetail);
        }
        public List<Departmentlist> Getdepartmet()
        {
            return _employeerepo.Getdepartmet();
        }
        public Employeemanagemet Edit(int id)
        {
            return _employeerepo.Edit(id);
        }
        public void Delete(int studentid)
        {
             _employeerepo.Delete(studentid);
        }
        public Employeemanagemet Details(int studentid)
        {
            return _employeerepo.Details(studentid);
        }
    }
}
