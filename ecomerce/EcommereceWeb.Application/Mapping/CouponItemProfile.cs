using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class CouponItemProfile : Profile
    {
        public CouponItemProfile()
        {
            CreateMap<CouponItemDto, CouponItem>().ReverseMap();
        }
    }




}
