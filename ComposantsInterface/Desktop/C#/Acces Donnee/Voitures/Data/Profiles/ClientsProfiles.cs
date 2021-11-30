using AutoMapper;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Dtos;

namespace Voitures.Data.Profiles
{
    public class ClientsProfiles : Profile
    {
        public ClientsProfiles()
        {
            CreateMap<Client, ClientsDtosIn>();
            CreateMap<ClientsDtosIn, Client>();
            CreateMap<Client, ClientsDtosOut>();
            CreateMap<ClientsDtosOut, Client>();
        }
    }
}
