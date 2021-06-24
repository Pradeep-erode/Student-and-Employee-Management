using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studentmanagement.Core.Iservices;
using Studentmanagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Employeemanagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeIService _employ;

        public string SessionKeyName { get; private set; }

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
                HttpContext.Session.SetString("username", employeelogin.username);
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
        public ActionResult Create(int id)
        {
            Employeemanagemet employeeedit = new Employeemanagemet();
            if (id > 0)
            {
                var employeeedi = _employ.Edit(id);
                employeeedi.departmentlist = _employ.Getdepartmet();
                return View(employeeedi);
            }
            employeeedit.departmentlist = _employ.Getdepartmet();
            return View(employeeedit);

        }
        [HttpPost]
        public ActionResult Create(Employeemanagemet employeedetail)
        {
            _employ.Create(employeedetail);
            return RedirectToAction("Dashboard");
        }
        
        public ActionResult Delete(int studentid)
        {
            _employ.Delete(studentid);
            return RedirectToAction("Dashboard");
        }
        public ActionResult Details(int studentid)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                var view = _employ.Details(studentid);
                return View(view);
            }
            else 
            {
                return RedirectToAction("Index");
            }
        }
    }
}
