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
    public class StudentinfoServices: StudentIService
    {
        StudentIRepository _repositorya;
        public StudentinfoServices(StudentIRepository repository)
        {
            _repositorya = repository;
        }
        public void Addstudentinfo(Studentinfomodel create)
        {
            _repositorya.Addstudentinfo(create);
        }
        public IEnumerable<Studentinfomodel> displayinfo()
        {
            return _repositorya.displayinfo();
        }
        public void marklistadd(StudentMarkmodel markbase)
        {
            _repositorya.marklistadd(markbase);
        }
        public IEnumerable<StudentMarkmodel> Marklist()
        {
            return _repositorya.Marklist();
        }
        public List<Departmentdetails> GetAllDepartment()
        {
            return _repositorya.GetAllDepartment();
        }
        public Departmentdetails GetDepartmentName(int id)
        {
            throw new NotImplementedException();
        }
        public List<Namelist> Namelist()
        {
            return _repositorya.Namelist();
        }
        public void Deletemark(int id)
        {
            _repositorya.Deletemark(id);
        }
        public void DeleteInfo(int id)
        {
            _repositorya.DeleteInfo(id);
        }
    }
}
