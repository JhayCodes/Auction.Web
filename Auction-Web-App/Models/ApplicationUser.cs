using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Auction_Web_App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        
    }
}
