using DotNetLearner.API.Data;
using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;

namespace DotNetLearner.API.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public Product Create(ProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price!.Value
            };

            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public bool Update(int id, ProductDto dto)
        {
            var product = _context.Products.Find(id);
            if (product == null) return false;

            product.Name = dto.Name ?? product.Name;
            product.Price = dto.Price ?? product.Price;

            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return false;

            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }
    }
}
