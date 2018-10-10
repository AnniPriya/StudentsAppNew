using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsApp;
using System.Web;

namespace StudentsAppTests
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void DataTest()
        {
            StudentsApp.students.StudentTransactions cont = new StudentsApp.students.StudentTransactions();
            if(cont.loadStudents().Count %2!=0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
