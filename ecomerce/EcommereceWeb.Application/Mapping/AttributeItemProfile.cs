using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class AttributeItemProfile : Profile
    {
        public AttributeItemProfile()
        {
            CreateMap<AttributeItemDto, AttributeItem>().ReverseMap();
        }
    }

}
