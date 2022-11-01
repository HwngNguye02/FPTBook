using System.ComponentModel.DataAnnotations;

namespace ASM1670.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Name length must be at least 5 characters")]
        public string Name { get; set; }
        [Required]
        [Range(10000, 1000000, ErrorMessage = "Price must be from 10000 to 1.000.000")]
        public double Price { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Image { get; set; }        
        public string Language { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Quanity must be from 1 to 100")]
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
