using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Buz.Data;
using Purple_Buz.Models.About;
using Purple_Buz.Models.Home;

namespace Purple_Buz.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var works = _context.Works.ToList();
            var workList = new List<WorkVM>();
            foreach (var work in works)
            {
                var workVM = new WorkVM
                {
                    Title = work.Title,
                    ImgUrl = work.ImgUrl,
                    Detail = work.Detail
                };
                workList.Add(workVM);
            }
            var model = new HomeIndexVM { WorksVM = workList };
            return View(model);
        }
    }
}
