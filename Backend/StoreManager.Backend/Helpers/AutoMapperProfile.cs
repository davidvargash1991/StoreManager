using AutoMapper;
using StoreManager.Backend.Dto;
using StoreManager.Data.Entities;

namespace StoreManager.Backend.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
