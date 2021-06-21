using Studentmanagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Studentmanagement.Core.Models
{
    public class Studentinfomodel
    {
        [Key]
        public int studentId { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public string name { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string mail { get; set; }
        [Required(ErrorMessage ="Please select your Department")]
        public string StudentDepartment { get; set; }
        [Required(ErrorMessage = "Please select your Department")]
        public List<Departmentdetails> Department { get; set; }
        [Required(ErrorMessage ="Select Gender")]
        public string Gender { get; set; }

    }

}
