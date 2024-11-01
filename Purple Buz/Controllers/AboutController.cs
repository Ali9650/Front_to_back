using Microsoft.AspNetCore.Mvc;
using Purple_Buz.Data;
using Purple_Buz.Entities;
using Purple_Buz.Models.About;

namespace Purple_Buz.Controllers
{
    public class AboutController : Controller
    {
        private AppDbContext _context;
        public AboutController(AppDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            var teamMembers= _context.TeamMembers.ToList();
            var aboutServices= _context.AboutServices.ToList();
            var teamMembersList = new List<TeamMembersVM>();
            var aboutServicesList=new List<AboutServiceVM>();
            foreach (var teamMember in teamMembers)
            {
                var teamMemberVM= new TeamMembersVM
                {
                    Name = teamMember.Name,
                    Surname = teamMember.Surname,
                    ImgUrl = teamMember.ImgUrl,
                    Position = teamMember.Position
                };
                teamMembersList.Add(teamMemberVM);  
            }
            foreach (var aboutService in aboutServices)
            {
                var aboutServiceVM = new AboutServiceVM
                {
                    IconClass = aboutService.IconClass,
                    Description = aboutService.Description,
                    Title = aboutService.Title
                };
                aboutServicesList.Add(aboutServiceVM);
            }
            var model=new AboutIndexVM { TeamMembers = teamMembersList , AboutServices= aboutServicesList};
            
            return View(model);
        }
    }
}
