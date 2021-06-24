using Studentmanagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement.Core.Iservices
{
    public interface StudentIService
    {
        public void Addstudentinfo(Studentinfomodel create);

        public IEnumerable<Studentinfomodel> displayinfo();

        public void marklistadd(StudentMarkmodel markbase);
        public IEnumerable<StudentMarkmodel> Marklist();
        public Departmentdetails GetDepartmentName(int id);
        List<Departmentdetails> GetAllDepartment();
        public List<Namelist> Namelist();

        public void Deletemark(int id);
        public void DeleteInfo(int id);
    }
}
