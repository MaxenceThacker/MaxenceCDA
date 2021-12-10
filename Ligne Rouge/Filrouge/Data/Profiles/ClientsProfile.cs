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
    class ClientsProfile : Profile
    {
        public ClientsProfile()
        {
            CreateMap<Clients, ClientsDTOIn>();
            CreateMap<ClientsDTOIn, Clients>();
            CreateMap<Clients, ClientsDTOOut>()
                .ForMember(d => d.LibelleCategClient, o => o.MapFrom(s => s.CategoriesClient.LibelleCategClient));
            CreateMap<ClientsDTOOut, Clients>();
        }
    }
}