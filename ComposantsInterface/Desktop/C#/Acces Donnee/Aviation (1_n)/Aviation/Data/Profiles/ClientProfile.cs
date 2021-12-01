using AutoMapper;
using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aviation.Data.Dtos;

namespace Aviation.Data.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDtosIn>();
            CreateMap<ClientDtosIn, Client>();

            CreateMap<Client, ClientDtosOut>();
            CreateMap<ClientDtosOut, Client>();

            CreateMap<Client, ClientDtosAvecApparteniragence>();
            CreateMap<ClientDtosAvecApparteniragence, Client>();

        }
    }
}
