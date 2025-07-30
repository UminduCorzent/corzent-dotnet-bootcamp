using System.ComponentModel.DataAnnotations;

namespace DotNetLearner.API.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(1, 1000000)]
        public decimal Price { get; set; }
    }
}
