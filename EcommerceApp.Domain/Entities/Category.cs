using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string? CategoryName{get; set;}

        public ICollection<Product>? Products  { get; set; }
    }

}