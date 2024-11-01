using Microsoft.AspNetCore.Mvc;
using Purple_Buz.Data;
using Purple_Buz.Models.About;
using Purple_Buz.Models.Contact;

namespace Purple_Buz.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController( AppDbContext context)
        {
            _context = context;  
        }
        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();
            var contactsList = new List<ContactVM>();
            foreach (var contact in contacts)
            {
                var contactVM = new ContactVM
                {
                   IconClasses=contact.IconClasses,
                   Title=contact.Title,
                   Name=contact.Name,
                   Phone=contact.Phone,
                };
                contactsList.Add(contactVM);
            }
            var model = new ContactIndexVM { Contacts = contactsList };
            return View(model);
        }
    }
}
