using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Video()
        {
            return View();
        }
    }
}
