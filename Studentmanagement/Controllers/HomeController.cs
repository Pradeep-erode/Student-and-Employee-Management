using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Studentmanagement.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Studentmanagement.Core.Iservices;
using Studentmanagement.Core.Models;

namespace Studentmanagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentIService _student;

        public HomeController(StudentIService repository)
        {
            _student = repository;
        }
        public ActionResult StudentInfoAdd()
        {
            //as we get a listof department error occur so we create instance on our model and add list in that
            Studentinfomodel dataa = new Studentinfomodel();
            dataa.Department=_student.GetAllDepartment();
            return View(dataa);
        }
        [HttpPost]
        public ActionResult Show(Studentinfomodel create)
        {
            //checking server side validation
            if (ModelState.IsValid)
            {
                _student.Addstudentinfo(create);
                return RedirectToAction("Display");
            }
            return RedirectToAction("StudentInfoAdd");
        }
        public ActionResult Display()
        {
            var listofstudent =_student.displayinfo();
            return View(listofstudent);
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AddMarks()
        {
            StudentMarkmodel listta = new StudentMarkmodel();
            listta.Namelist = _student.Namelist();
            return View(listta);
        }
        [HttpPost]
        public ActionResult Marksupdate(StudentMarkmodel markbase)
        {
            if (ModelState.IsValid)
            {
                _student.marklistadd(markbase);
                return RedirectToAction("markpost");
            }
            return RedirectToAction("markpost");

        }
        public ActionResult markpost()
        {
           var listofmarklist =_student.Marklist();
           return View(listofmarklist);
        }
        public ActionResult Deletemark(int studentid)
        {
            _student.Deletemark(studentid);
            return RedirectToAction("markpost");
        }
        public ActionResult Delete(int studentid)
        {
            _student.DeleteInfo(studentid);
            return RedirectToAction("Display");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
