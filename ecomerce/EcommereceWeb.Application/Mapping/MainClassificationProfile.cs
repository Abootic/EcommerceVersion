using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class MainClassificationProfile : Profile
    {
        public MainClassificationProfile()
        {
            CreateMap<MainClassificationDto, MainClassification>().ReverseMap();
        }
    }




}
