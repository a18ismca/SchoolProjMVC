using Microsoft.AspNetCore.Mvc;

namespace SchoolProjMVC.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
