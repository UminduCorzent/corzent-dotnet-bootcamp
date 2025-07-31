using System.ComponentModel.DataAnnotations;

namespace DotNetLearner.API.DTOs
{
    public class ProductDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(1, 1000000)]
        public decimal? Price { get; set; }
    }
}
