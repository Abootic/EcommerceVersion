using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class ProductEvaluatonProfile : Profile
    {
        public ProductEvaluatonProfile()
        {
            CreateMap<ProductEvaluatonDto, ProductEvaluaton>().ReverseMap();
        }
    }




}
