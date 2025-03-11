using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
    }
}
