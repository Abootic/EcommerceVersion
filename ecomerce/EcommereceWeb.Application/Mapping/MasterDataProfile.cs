using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class MasterDataProfile : Profile
    {
        public MasterDataProfile()
        {
            CreateMap<MasterDataDto, MasterData>().ReverseMap();
        }
    }




}
