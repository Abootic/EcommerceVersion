using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandDto, Brand>().ReverseMap();
        }
    }

}
