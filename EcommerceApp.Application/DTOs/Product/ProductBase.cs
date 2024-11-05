using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Application.DTOs.Product
{
    public class ProductBase
    {
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]
        public int Quantity { get; set; }

        public Guid CategoryId { get; set; }


    }


}
