using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auction_Web_App.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Price { get; set; }

        [Required]
        public string? userId { get; set; }
        [ForeignKey("userId")]
        public ApplicationUser? user { get; set; }

        public int? ListingId { get; set; }
        public Listing? Listing { get; set; }


    }
}
