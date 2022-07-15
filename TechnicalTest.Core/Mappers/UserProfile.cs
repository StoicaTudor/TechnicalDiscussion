using AutoMapper;
using TechnicalTest.Core.Dtos.User;
using TechnicalTest.Core.Entities;

namespace TechnicalTest.Core.Mappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}