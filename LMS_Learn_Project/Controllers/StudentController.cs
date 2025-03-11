using LMS_Learn_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student s)
        {
            //IEnumerable<Student> register = s1.Studentregistertbl();
            //s1.studentregistertbl.Add(s);
            //s1.SaveChanges();

            return View();
        }
    }
}
