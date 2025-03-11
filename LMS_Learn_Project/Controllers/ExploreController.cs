using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
