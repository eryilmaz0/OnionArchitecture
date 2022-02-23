using AutoMapper;
using OnionArchitectureDemo.Application.ViewModels;
using OnionArchitectureDemo.Domain.Entity;

namespace OnionArchitectureDemo.Application.MapperProfile
{
    public class GeneralMapper : Profile
    {
        public GeneralMapper()
        {
            CreateMap<Product, GetProductsViewModel>().ReverseMap();
            CreateMap<Product, GetProductViewModel>().ReverseMap();
        }
    }
}