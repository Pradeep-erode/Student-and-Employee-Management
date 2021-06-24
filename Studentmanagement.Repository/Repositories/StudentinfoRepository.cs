using Studentmanagement.Core.IRepository;
using Studentmanagement.Core.Models;
using Studentmanagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement.Repository.Repositories
{
    public class StudentinfoRepository: StudentIRepository
    {
        public void Addstudentinfo(Studentinfomodel create)
        {
            using (Studentfirstcontext listt = new Studentfirstcontext())
            {
                Studentinfo addon = new Studentinfo();
                addon.Name = create.name;
                addon.Email = create.mail;
                if (create.StudentDepartment == "1")
                {
                    create.StudentDepartment = "ECE";
                }
                else if (create.StudentDepartment == "2")
                {
                    create.StudentDepartment = "EEE";
                }
                else if (create.StudentDepartment == "3")
                {
                    create.StudentDepartment = "CSE";
                }
                else if (create.StudentDepartment == "4")
                {
                    create.StudentDepartment = "IT";
                }
                else if (create.StudentDepartment == "4")
                {
                    create.StudentDepartment = "MECH";
                }
                addon.DepartmentName = create.StudentDepartment;
                addon.Gender = create.Gender;
                listt.Studentinfo.Add(addon);
                listt.SaveChanges();   
            }
  
        }
        public IEnumerable<Studentinfomodel> displayinfo()
        {
            List<Studentinfomodel> listat = new List<Studentinfomodel>();
            using (Studentfirstcontext entitya = new Studentfirstcontext())
            {
                var baslist = entitya.Studentinfo.Where(m=>m.IsDeleted == false).ToList();
                foreach (var basea in baslist)
                {
                    Studentinfomodel ourmodel = new Studentinfomodel();
                    ourmodel.studentId = basea.StudentId;
                    ourmodel.name = basea.Name;
                    ourmodel.mail = basea.Email;
                    ourmodel.StudentDepartment = basea.DepartmentName;
                    ourmodel.Gender = basea.Gender;
                    listat.Add(ourmodel);
                    
                }
                return listat;
            }
        }
        public void marklistadd(StudentMarkmodel markbase)
        {

            using (Studentfirstcontext entit = new Studentfirstcontext())
            {
                var check = entit.Studentmark.Where(m => m.Name == markbase.Name && m.IsDeleted==false).SingleOrDefault();
                if (check != null )
                {
                    check.Name = markbase.Name;
                    check.Mark1 = markbase.mark1;
                    check.Mark2 = markbase.mark2;
                    entit.SaveChanges();
                }

                else
                {
                    Studentmark basemark = new Studentmark();
                    basemark.Name = markbase.Name;
                    basemark.Mark1 = markbase.mark1;
                    basemark.Mark2 = markbase.mark2;
                    entit.Add(basemark);
                    entit.SaveChanges();
                }
            }
                
            
        }
        public IEnumerable<StudentMarkmodel> Marklist()
        {
            using (Studentfirstcontext entit = new Studentfirstcontext())
            {
                List<StudentMarkmodel> list = new List<StudentMarkmodel>();
                //var listofmark = entit.Studentmark.Where(m => m.IsDeleted == false).ToList();
                var joinresult = from c in entit.Studentmark
                                 join d in entit.Studentinfo on c.Name equals d.StudentId where c.IsDeleted==false
                                 && d.IsDeleted==false
                                 select new
                                 {
                                     studentID=c.StudentId,
                                     StudentName = d.Name,
                                     Mark1=c.Mark1,
                                     Mark2=c.Mark2,
                                     Total=c.Total
                                 };
                foreach (var mark in joinresult)
                {
                    StudentMarkmodel listof = new StudentMarkmodel();
                    //listof.studentId = mark.StudentId;
                    listof.studentId = mark.studentID;
                    listof.Namestring = mark.StudentName;
                    listof.mark1 = mark.Mark1;
                    listof.mark2 = mark.Mark2;
                    //as total is nullable type it must be casted to integer.
                    listof.total = (int)mark.Total;
                    list.Add(listof);
                    
                }
                return list;
            }
        }
        public Departmentdetails GetDepartmentName(int id)
        {
            throw new NotImplementedException();
        }
        public List<Departmentdetails> GetAllDepartment()
        {
            List<Departmentdetails> departmentList = new List<Departmentdetails>();
            using (var entites = new Studentfirstcontext())
            {
                var dbDepartment = entites.DepartmentDetail.ToList();
                if (dbDepartment != null)
                {
                    foreach (var departmntData in dbDepartment)
                    {
                        Departmentdetails departmentDetails = new Departmentdetails();
                        departmentDetails.DepartmentId = departmntData.DepartmentId;
                        departmentDetails.DepartmentName = departmntData.DepartmentName;
                        departmentList.Add(departmentDetails);
                    }
                }
            }
            return departmentList;
        }

        public List<Namelist> Namelist()
        {
            List<Namelist> listo = new List<Namelist>();
            using (var entites = new Studentfirstcontext())
            {
                var listu = entites.Studentinfo.Where(m => m.IsDeleted == false).ToList();
                //var listu=(from var in namelist where(var.IsDeleted==false)select var.Name);
                //        listu.ToList();

                foreach (var listofname in listu)
                {
                    Namelist listmake = new Namelist();
                    listmake.studentID = listofname.StudentId;
                    listmake.Studentname = listofname.Name;
                    listo.Add(listmake);
                }
                return listo;
            }
        }
        public void Deletemark(int id)
        {
            using (var entites = new Studentfirstcontext())
            {
                var list = entites.Studentmark.Where(m => m.StudentId == id).SingleOrDefault();
                list.IsDeleted = true;
                entites.SaveChanges();
            }
        }
        public void DeleteInfo(int id)
        {
            using (var entites = new Studentfirstcontext())
            {
                var list = entites.Studentinfo.Where(m => m.StudentId == id).SingleOrDefault();
                list.IsDeleted = true;
                list.UpdatedTimeStamp = DateTime.Now;
                entites.SaveChanges();
            }
        }

    }
}
