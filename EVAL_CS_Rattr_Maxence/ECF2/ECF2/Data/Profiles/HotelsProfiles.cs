using AutoMapper;
using ECF2.Data.DTOs;
using ECF2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF2.Data.Profiles
{
    class HotelsProfiles : Profile
    {
        public HotelsProfiles()
        {
            CreateMap<Hotel, HotelsDTOIn>();
            CreateMap<HotelsDTOIn, Hotel>();
            CreateMap<Hotel, HotelsDTOOut>();
            CreateMap<HotelsDTOOut, Hotel>();
        }
    }
}
