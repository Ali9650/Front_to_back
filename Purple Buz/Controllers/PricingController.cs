using Microsoft.AspNetCore.Mvc;
using Purple_Buz.Data;
using Purple_Buz.Models.About;
using Purple_Buz.Models.Pricing;

namespace Purple_Buz.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pricings = _context.Pricings.ToList();
            var pricingsList = new List<PricingVM>();
            foreach (var pricing in pricings)
            {
                var pricingVM = new PricingVM
                {
                   Title= pricing.Title,
                   Price= pricing.Price,
                   UserCapacity= pricing.UserCapacity,
                   SpaceCapacity= pricing.SpaceCapacity,
                   Type= pricing.Type,
                   Servicing= pricing.Servicing,
                   Customize= pricing.Customize,
                };
                pricingsList.Add(pricingVM);
            }
            var model = new PricingIndexVM { Pricings=pricingsList };
            return View(model);
        }
    }
}
