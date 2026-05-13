using System.ComponentModel.DataAnnotations;

namespace SmartShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        public string Description { get; set; } = "Product";

        [Required(ErrorMessage = "Price is required")]
        [Range(0, 100, ErrorMessage = "Price must be between 0 and 100")]
        public decimal Price { get; set; }
        public string? Rate { get; set; } 
        public int CategoryId { get; set; }
    }
}
