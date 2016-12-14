using CAExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAExamples.Controllers
{
    public class StudentController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student student)
        {
            return RedirectToAction("Details", student);
        }

        public ActionResult Details(Student student)
        {
            return View(student);
        }

        public ActionResult Edit(Student student)
        {
            if (Request.HttpMethod == "POST")
            {
                return RedirectToAction("Details", student);
            }
            else
            {
                return View(student);
            }
        }

        public ActionResult GetList()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { Name = "Dean", Age = 25 });
            studentList.Add(new Student() { Name = "Seamus", Age = 25 });
            studentList.Add(new Student() { Name = "aaron", Age = 31 });
            return View(studentList);
        }
    }
}