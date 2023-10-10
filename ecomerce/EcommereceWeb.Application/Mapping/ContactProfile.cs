using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<ContactDto, Contact>().ReverseMap();
        }
    }




}
