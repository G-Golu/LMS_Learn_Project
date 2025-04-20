using Microsoft.AspNetCore.Mvc;

namespace LMS_Learn_Project.Controllers
{
    public class PurchasedController : Controller
    {
        public IActionResult PurchasedCourse()
        {
            return View();
        }
    }
}
