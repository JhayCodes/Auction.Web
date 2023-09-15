using AuctionIt.Data.Services;
using AuctionIt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AuctionIt.Controllers
{
    public class ListingController : Controller
    {
        private readonly IListingService _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

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

        //GET - Create
        public async Task<IActionResult> Create()
        {
             return View();
        }

        //POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ListingViewModel list)
        {
            //special case for image
            //check if image is not null
            if(list.Image != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "Images"); //store upload directory
                string fileName = list.Image.FileName; //gets the name of the file uploaded
                string filePath = Path.Combine(uploadDir, fileName); //specifies where file is stored
                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    list.Image.CopyTo(fileStream);
                }

                var listObj = new Listing
                {
                    Title = list.Title,
                    Description = list.Description,
                    Price = list.Price,
                    userId = list.userId,
                    ImagePath = filePath,
                };
                await _context.Add(listObj);
                return RedirectToAction("Index");
            }

            return View(list);
        }
    }
}
