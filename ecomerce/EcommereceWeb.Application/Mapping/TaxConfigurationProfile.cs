using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class TaxConfigurationProfile : Profile
    {
        public TaxConfigurationProfile()
        {
            CreateMap<TaxConfigurationDto, TaxConfiguration>().ReverseMap();
        }
    }




}
