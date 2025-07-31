using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;

namespace DotNetLearner.API.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> _products = new List<Product>();
        private static int _nextId = 1;

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product Create(ProductDto dto)
        {
            var product = new Product
            {
                Id = _nextId++,
                Name = dto.Name,
                Price = dto.Price!.Value
            };

            _products.Add(product);
            return product;
        }

        public bool Update(int id, ProductDto dto)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;

            product.Name = dto.Name ?? product.Name;
            product.Price = dto.Price ?? product.Price;

            return true;
        }

        public bool Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return false;

            _products.Remove(product);
            return true;
        }
    }
}
