using AutoMapper;
using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;

namespace DotNetLearner.API.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>();   // Add `.ReverseMap()` to allow mapping both ways
        }
    }
}
