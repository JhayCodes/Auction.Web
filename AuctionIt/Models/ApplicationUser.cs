using Microsoft.AspNetCore.Identity;

namespace AuctionIt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
