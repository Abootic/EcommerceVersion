using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class ProductAttributeProfile : Profile
    {
        public ProductAttributeProfile()
        {
            CreateMap<ProductAttributeDto, ProductAttribute>().ReverseMap();
        }
    }

}
