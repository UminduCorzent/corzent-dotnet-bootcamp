using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;

namespace DotNetLearner.API.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        Product Create(ProductDto dto);
        bool Update(int id, ProductDto dto);
        bool Delete(int id);
    }
}
