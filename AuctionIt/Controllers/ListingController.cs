using AuctionIt.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuctionIt.Controllers
{
    public class ListingController : Controller
    {
        private readonly IListingService _context;
        public ListingController(IListingService context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var listings = await _context.GetAll()
                .ToListAsync();
            return View(listings);
        }
    }
}
