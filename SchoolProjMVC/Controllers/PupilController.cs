using Microsoft.AspNetCore.Mvc;

namespace SchoolProjMVC.Controllers
{
    public class PupilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
