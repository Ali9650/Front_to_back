using Microsoft.AspNetCore.Mvc;

namespace Purple_Buz.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
