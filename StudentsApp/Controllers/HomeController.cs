using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> listStudents = new List<Student>();

            listStudents.Add(new Student { firstName = "Dhanjunjay", Mid = "M1048649", LastName = "XYZ", Company = "Mindtree" });
            listStudents.Add(new Student { firstName = "Dhanjunjay", Mid = "M1048649", LastName = "XYZ", Company = "Mindtree" });
            return View(listStudents);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class Student
    {
        public string firstName { get; set; }
        public string Company { get; set; }
        public string Mid { get; set; }
        public string LastName { get; set; }
    }
}