using AutoMapper;
using EcommereceWeb.Application.DTOs;
using EcommereceWeb.Domain.Entity;

namespace EcommereceWeb.Application.Mapper
{
    public class AddProductToFavoriteProfile : Profile
    {
        public AddProductToFavoriteProfile()
        {
            CreateMap<AddProductToFavoriteDto, AddProductToFavorite>().ReverseMap();
        }
    }
}
