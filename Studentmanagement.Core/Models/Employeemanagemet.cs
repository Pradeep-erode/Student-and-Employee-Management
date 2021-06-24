using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement.Core.Models
{
    public class Employeemanagemet
    {
        public int studentID { get; set; }


        //If you want to validate in a separate class you can add like this and do validate 
        //link=https://www.c-sharpcorner.com/UploadFile/rahul4_saxena/mvc-4-custom-validation-data-annotation-attribute/
        //custom validation ==  [CustomEmailValidator]



        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only")]
        public string fullname { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only")]
        public string username { get; set; }
        //[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
        //                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
        //                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
        //                    ErrorMessage = "Email is not valid")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int department { get; set; }
        public string departmentstring { get; set; }
        public List<Departmentlist> departmentlist { get; set; }
        [Required(ErrorMessage ="Please enter your work")]
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z]+$",ErrorMessage ="Use letters only")]
        public string work { get; set; }
        [Required]
        [StringLength(20)]
        public string address { get; set; }
        [Required(ErrorMessage ="Phone number is Must")]
        [MaxLength(10)]
        [MinLength(10, ErrorMessage = "Enter a Valid 10 digit phone number")]
       // [Range(0, 9999999999, ErrorMessage = "Enter a Valid 10 digit phone number")]
        [Phone]
        public string phonenumber { get; set; }
        [Required(ErrorMessage ="Gender is must")]
        public string gender { get; set; }

    }
    public class Departmentlist
    {
        public int departmentID { get; set; }
        public string departmentname { get; set; }
    }
}
