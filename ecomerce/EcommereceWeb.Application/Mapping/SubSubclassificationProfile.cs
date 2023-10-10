using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class SubSubclassificationProfile : Profile
    {
        public SubSubclassificationProfile()
        {
            CreateMap<SubSubclassificationDto, SubSubclassification>().ReverseMap();
        }
    }




}
