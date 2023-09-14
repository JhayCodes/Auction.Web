using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionIt.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }


        [Required]
        public string? userId { get; set; }
        [ForeignKey("userId")]
        public ApplicationUser? user { get; set; }

        public int? ListingId { get; set; }
        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }

    }
}
