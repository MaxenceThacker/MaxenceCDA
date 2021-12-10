using AutoMapper;
using Filrouge.Data.Dtos;
using Filrouge.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filrouge.Data.Profiles
{
    class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<Users, UsersDTOIn>();
            CreateMap<UsersDTOIn, Users>();
            CreateMap<Users, UsersDTOOut>()
                .ForMember(d => d.LibelleRole, o => o.MapFrom(s => s.Roles.LibelleRole));
            CreateMap<UsersDTOOut, Users>();
        }
    }
}