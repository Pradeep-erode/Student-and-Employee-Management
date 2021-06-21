using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement.Core.Models
{
    public class Employeemanagemet
    {
        public int studentID { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public int department { get; set; }

        public string departmentstring { get; set; }
        public List<Departmentlist> departmentlist { get; set; }
        public string work { get; set; }
        public string address { get; set; }

        public string phonenumber { get; set; }
        public string gender { get; set; }

    }
    public class Departmentlist
    {
        public int departmentID { get; set; }
        public string departmentname { get; set; }
    }
}
