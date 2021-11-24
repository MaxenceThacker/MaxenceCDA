using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Personnes.Data.Dtos;
using Personnes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnes.Data.Profiles
{
    public class PersonnesProfile : Profile
    {
        public PersonnesProfile()
        { 
            CreateMap<Personne, PersonnesDTO>(); 
            CreateMap<PersonnesDTO, Personne>(); 
        }
    }
}
