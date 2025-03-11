using LMS_Learn_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class SignUpController1 : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save user to the database (logic goes here)
                return RedirectToAction("Login");
            }

            return View(model);
        }
    }
}



