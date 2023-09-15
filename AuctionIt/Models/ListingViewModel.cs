using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuctionIt.Models
{
    public class ListingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IFormFile Image { get; set; }
        public bool IsSold { get; set; } = false;

        [Required]
        public string? userId { get; set; }
        [ForeignKey("userId")]
        public ApplicationUser? user { get; set; }
    }
}
