using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class DetailsDataProfile : Profile
    {
        public DetailsDataProfile()
        {
            CreateMap<DetailsDataDto, DetailsData>().ReverseMap();
        }
    }




}
