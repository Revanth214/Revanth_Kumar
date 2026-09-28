using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models.DTOs
{
    public class UpdateProductDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [RegularExpression("^(Electronics|Grocery|Clothing|Other)$")]
        public string Category { get; set; } = string.Empty;

        [Range(typeof(decimal), "0.01", "99999999.99")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }
    }
}