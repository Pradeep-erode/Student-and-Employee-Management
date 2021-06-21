using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement.Core.Models
{
    public class StudentMarkmodel
    {
        public int studentId { get; set; }
        public int Name { get; set; }

        public string Namestring { get; set; }
        public int mark1 { get; set; }
        public int mark2 { get; set; }
        public int total { get; set; }

        public List<Namelist> Namelist { get; set; }
    }
    public class Namelist
    {
        public int studentID { get; set; }
        public string Studentname { get; set; }
    }
}
