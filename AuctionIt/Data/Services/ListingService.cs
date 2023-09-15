using AuctionIt.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionIt.Data.Services
{
    public class ListingService : IListingService
    {
        private readonly ApplicationDbContext _db;
        public ListingService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IQueryable<Listing> GetAll()
        {
            var allListing = _db.Listings
                .Include(u => u.user);
            
            return allListing;
        }

        public async Task Add(Listing obj)
        {

            _db.Listings.Add(obj);
            await _db.SaveChangesAsync();
        }
    }
}
