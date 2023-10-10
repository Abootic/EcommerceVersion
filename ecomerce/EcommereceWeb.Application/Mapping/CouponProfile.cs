using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class CouponProfile : Profile
    {
        public CouponProfile()
        {
            CreateMap<CouponDto, Coupon>().ReverseMap();
        }
    }




}
