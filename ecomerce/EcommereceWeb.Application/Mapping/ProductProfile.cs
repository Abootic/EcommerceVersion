using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
        }
    }




}
