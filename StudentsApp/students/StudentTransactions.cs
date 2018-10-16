using StudentsApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsApp.students
{
    public class StudentTransactions
    {
        public List<Student> loadStudents()
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student { firstName = "Dhanjunjay", Mid = "M1048649", LastName = "Xyz", Company = "Mindtree" });
            listStudents.Add(new Student { firstName = "Dhanjunjay", Mid = "M1048649", LastName = "Xyz", Company = "Mindtree" });
            listStudents.Add(new Student { firstName = "surendra", Mid = "M1048649", LastName = "Xyz", Company = "Mindtree" });
            listStudents.Add(new Student { firstName = "Ramesh", Mid = "M1048649", LastName = "Xyz", Company = "Mindtree" });
            listStudents.Add(new Student { firstName = "Suresh", Mid = "M1048649", LastName = "Xyz", Company = "Mindtree" });
            listStudents.Add(new Student { firstName = "Rajini", Mid = "M1048649", LastName = "Xyz", Company = "Mindtree" });

            return listStudents;
        }
    }
}
