using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class SubClassificationBaseProfile : Profile
    {
        public SubClassificationBaseProfile()
        {
            CreateMap<SubClassificationBaseDto, SubClassificationBase>().ReverseMap();
        }
    }




}
