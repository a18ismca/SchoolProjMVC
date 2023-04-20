using Microsoft.AspNetCore.Mvc;

namespace SchoolProjMVC.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
