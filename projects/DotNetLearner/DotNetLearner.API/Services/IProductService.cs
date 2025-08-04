using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;

namespace DotNetLearner.API.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Create(ProductDto dto);
        Task<bool> Update(int id, ProductDto dto);
        Task<bool> Delete(int id);
    }
}
