using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;  // Initializare cu un string gol

        public string Description { get; set; } = string.Empty;  // Initializare cu un string gol

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be at least 0.")]
        public int Stock { get; set; }
    }
}
