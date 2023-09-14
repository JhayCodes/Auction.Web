using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionIt.Models
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
        [ForeignKey("LisingId")]
        public Listing? Listing { get; set; }
    }
}
