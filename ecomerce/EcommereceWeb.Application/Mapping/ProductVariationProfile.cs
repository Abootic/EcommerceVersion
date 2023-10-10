using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class ProductVariationProfile : Profile
    {
        public ProductVariationProfile()
        {
            CreateMap<ProductVariationDto, ProductVariation>().ReverseMap();
        }
    }

}
