using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auction_Web_App.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }

        //fk for listing 
        public int listingId { get; set; }
        public Listing listing { get; set; }

        [Required]
        public string? userId { get; set; }
        [ForeignKey("userId")]
        public ApplicationUser? user { get; set; }

    }
}
