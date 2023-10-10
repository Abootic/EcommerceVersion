using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class SliderProfile : Profile
    {
        public SliderProfile()
        {
            CreateMap<SliderDto, Slider>().ReverseMap();
        }
    }




}
