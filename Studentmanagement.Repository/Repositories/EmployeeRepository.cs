using Studentmanagement.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Studentmanagement.Entities;
using Studentmanagement.Core.Models;

namespace Studentmanagement.Repository.Repositories
{
    public class EmployeeRepository: EmployeeIRepository
    {
        //your model name and base model name should not same otherwise it show ambiguous error
        public int Admincheck(Core.Models.Employeelogin employeelogin)
        {
            using (var entity = new Studentfirstcontext())
            {
                var check = entity.Employeelogin.Where(m => m.Username == employeelogin.username && m.Password == employeelogin.password).Count();
                if (check == 1)
                {
                    return 1;
                }
                else {

                    return 0;
                }
            }    
        }
        public IEnumerable<Employeemanagemet> Dashboard()
        {
            List<Employeemanagemet> list = new List<Employeemanagemet>();
            using (var entity = new Studentfirstcontext())
            {
                var inner = from a in entity.Employeemanagement join
                            b in entity.DepartmentDetail on a.Department equals b.DepartmentId where a.IsDeleted==false
                            select new
                            {
                                StudentID = a.StudentId,
                                Fullname = a.Fullname,
                                Username = a.Username,
                                Email = a.Email,
                                Department = b.DepartmentName,
                                Work = a.Work,
                                Address = a.Address,
                                Phonenumber = a.Phonenumber,
                                Gender = a.Gender
                            };
                //var check = entity.Employeemanagement.Where(m => m.IsDeleted == false).ToList();
                foreach (var item in inner)
                {
                    Employeemanagemet lista = new Employeemanagemet();
                    lista.studentID = item.StudentID;
                    lista.fullname = item.Fullname;
                    lista.username = item.Username;
                    lista.Email = item.Email;
                    lista.departmentstring = item.Department;
                    lista.work = item.Work;
                    lista.address = item.Address;
                    lista.phonenumber = item.Phonenumber;
                    lista.gender = item.Gender;
                    list.Add(lista);
                }
                return list;
            } 
        }
        public void Create(Employeemanagemet employeedetail)
        {
            if (employeedetail.studentID > 0)
            {
                using (var entity = new Studentfirstcontext())
                {
                    var list = entity.Employeemanagement.Where(m => m.StudentId == employeedetail.studentID).SingleOrDefault();
                    list.Fullname = employeedetail.fullname;
                    list.Username = employeedetail.username;
                    list.Email = employeedetail.Email;
                    list.Department = employeedetail.department;
                    list.Work = employeedetail.work;
                    list.Address = employeedetail.address;
                    list.Phonenumber = employeedetail.phonenumber;
                    list.Gender = employeedetail.gender;
                    list.UpdatedTimeStamp = DateTime.Now;
                    //entity.Add(list);
                    entity.SaveChanges();
                }
            }
            else
            {
                using (var entity = new Studentfirstcontext())
                {
                    Employeemanagement add = new Employeemanagement();
                    add.Fullname = employeedetail.fullname;
                    add.Username = employeedetail.username;
                    add.Email = employeedetail.Email;
                    add.Department = employeedetail.department;
                    add.Work = employeedetail.work;
                    add.Address = employeedetail.address;
                    add.Phonenumber = employeedetail.phonenumber;
                    add.Gender = employeedetail.gender;
                    entity.Add(add);
                    entity.SaveChanges();
                }

            }
        }
        public List<Departmentlist> Getdepartmet()
        {
            List<Departmentlist> listofdepartment = new List<Departmentlist>();
            using (var entity = new Studentfirstcontext())
            {
                var departlist = entity.DepartmentDetail.ToList();
                foreach (var dep in departlist)
                {
                    Departmentlist add = new Departmentlist();
                    add.departmentID = dep.DepartmentId;
                    add.departmentname = dep.DepartmentName;
                    listofdepartment.Add(add);
                }
                return listofdepartment;
            }
        }
        public Employeemanagemet Edit(int id)
        {
            Employeemanagemet addforedit = new Employeemanagemet();
            using (var entity=new Studentfirstcontext())
            {
                var list = entity.Employeemanagement.Where(r => r.StudentId == id).SingleOrDefault();
                addforedit.studentID = list.StudentId;
                addforedit.fullname = list.Fullname;
                addforedit.username = list.Username;
                addforedit.Email = list.Email;
                //var listu = from c in entity.DepartmentDetail
                //            join d in entity.Employeemanagement on c.DepartmentId equals d.StudentId
                //            select new {
                //                   DepartmentId=c.DepartmentId,
                //                   Departmentnames = c.DepartmentName
                //               };
                //List<Departmentlist> listt = new List<Departmentlist>();
                //foreach (var deplist in listu)
                //{
                    
                //    Departmentlist depp = new Departmentlist();
                //    depp.departmentID = deplist.DepartmentId;
                //    depp.departmentname = deplist.Departmentnames;
                //    listt.Add(depp);
                //}
                addforedit.department = list.Department;
                addforedit.work = list.Work;
                addforedit.address = list.Address;
                addforedit.phonenumber = list.Phonenumber;
                addforedit.gender = list.Gender;
                return addforedit;
            }
        }
        public void Delete(int studentid)
        {
            using (var entity = new Studentfirstcontext())
            {
                var delete = entity.Employeemanagement.Where(m => m.StudentId == studentid).SingleOrDefault();
                delete.IsDeleted = true;
                entity.SaveChanges();
            }
        }
        public Employeemanagemet Details(int studentid)
        {
            //List<Employeemanagemet> viewlist = new List<Employeemanagemet>();
            using (var entity = new Studentfirstcontext())
            {
                var inner = from a in entity.Employeemanagement
                            join b in entity.DepartmentDetail on a.Department equals b.DepartmentId
                            where a.IsDeleted==false&&a.StudentId == studentid
                            select new
                            {
                                Fullname = a.Fullname,
                                Username = a.Username,
                                Email = a.Email,
                                Department = b.DepartmentName,
                                Work = a.Work,
                                Address = a.Address,
                                Phonenumber = a.Phonenumber,
                                Gender = a.Gender
                            };
                Employeemanagemet list = new Employeemanagemet();
                // var view = entity.Employeemanagement.Where(m => m.StudentId == studentid).SingleOrDefault();
                foreach (var view in inner)
                {
                    list.fullname = view.Fullname;
                    list.username = view.Username;
                    list.Email = view.Email;
                    list.departmentstring = view.Department;
                    list.work = view.Work;
                    list.address = view.Address;
                    list.phonenumber = view.Phonenumber;
                    list.gender = view.Gender;
                }
                return list;

            }
           
        }
    }
}
