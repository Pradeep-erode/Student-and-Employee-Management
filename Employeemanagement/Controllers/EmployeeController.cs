using Microsoft.AspNetCore.Mvc;
using Studentmanagement.Core.Iservices;
using Studentmanagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employeemanagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeIService _employ;
        public EmployeeController(EmployeeIService employe)
        {
            _employ = employe;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Admincheck(Employeelogin employeelogin)
        {
            var ckecking=_employ.Admincheck(employeelogin);
            if (ckecking == 1)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        public ActionResult Dashboard()
        {
            var employeelist = _employ.Dashboard();
            return View(employeelist);
        }
        public ActionResult Create(Employeemanagemet employeeedit, int id)
        {
            employeeedit.departmentlist = _employ.Getdepartmet();
            return View(employeeedit); 
        }
        [HttpPost]
        public ActionResult Create(Employeemanagemet employeedetail)
        {
            _employ.Create(employeedetail);
            return RedirectToAction("Dashboard");
        }
        public ActionResult Edit(int id)
        {
            var employeeedit = _employ.Edit(id);
            return RedirectToAction("Create", employeeedit);
        }
        public ActionResult Delete(int studentid)
        {
            _employ.Delete(studentid);
            return RedirectToAction("Dashboard");
        }
        public ActionResult Details(int studentid)
        {
            var view=_employ.Details(studentid);
            return View(view);
        }
    }
}
