using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class ProductUnitSizeProfile : Profile
    {
        public ProductUnitSizeProfile()
        {
            CreateMap<ProductUnitSizeDto, ProductUnitSize>().ReverseMap();
        }
    }




}
