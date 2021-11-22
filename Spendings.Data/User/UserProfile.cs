﻿using Spendings.Data.Users;
using AutoMapper;

namespace Spendings.Orchrestrators.Users
{
    public class UserDaoProfile : Profile
    {
        public UserDaoProfile()
        {
            CreateMap<Core.Users.User, User>()
                .ForMember(dest => dest.Login, memberOptions: opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.Password, memberOptions: opt => opt.MapFrom(src => src.Password)); 
        }
    }

    public class DaoUserProfile : Profile
    {
        public DaoUserProfile()
        {
            CreateMap<User, Core.Users.User>()
                .ForMember(dest => dest.Login, memberOptions: opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.Password, memberOptions: opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.Id, memberOptions: opt => opt.MapFrom(src => src.Id));
        }
    }
}
