using LMS_Learn_Project.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
public class CourseController : Controller
{
    public IActionResult Course()
    {
        
        var courses = new List<Course>
        {
            new Course { Title = ".NET Full Course 2025", Creator = "Rawat Jackon", Lectures = 18, Level = "Intermediate", Price = 55, ImageUrl = "/images/DB.jpg"  },
            new Course { Title = "React + TypeScript Full Course 2025", Creator = "Solian Doe", Lectures = 25, Level = "Advanced", Price = 45, ImageUrl = "/images/html css.jpg" },
            new Course { Title = "Computer Network Full Course 2025", Creator = "Ar Sajeed Alam", Lectures = 28, Level = "Beginner + Intermediate", Price = 40, ImageUrl = "/images/react.jpg" },
            new Course { Title = "Machine Learning with JS Full Course 2025", Creator = "John Doe", Lectures = 25, Level = "Intermediate", Price = 45, ImageUrl = "/images/student comp.jpg" }
        };
        return View(courses);
    }
}



