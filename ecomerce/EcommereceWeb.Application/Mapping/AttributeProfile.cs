using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;
using Attribute = EcommereceWeb.Domain.Entity.Attribute;

namespace EcommereceWeb.Application.Mapper
{
    public class AttributeProfile : Profile
    {
        public AttributeProfile()
        {
            CreateMap<AttributeDto, Attribute>().ReverseMap();
        }
    }

}
