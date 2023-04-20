using Microsoft.AspNetCore.Mvc;

namespace SchoolProjMVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
