using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class MyCourseController : Controller
    {
        public IActionResult MyCourse()
        {
            return View();
        }
    }
}
