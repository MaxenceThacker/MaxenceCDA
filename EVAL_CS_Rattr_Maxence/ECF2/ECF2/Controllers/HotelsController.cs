using AutoMapper;
using ECF2.Data;
using ECF2.Data.DTOs;
using ECF2.Data.Models;
using ECF2.Data.Profiles;
using ECF2.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF2.Controllers
{
    class HotelsController : ControllerBase
    {

        private readonly HotelsServices _service;
        private readonly IMapper _mapper;


        public HotelsController(Ecf2Context context)
        {
            _service = new HotelsServices(context);
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<HotelsProfiles>();
                cfg.AddProfile<ChambresProfiles>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<HotelsDTOOut> GetAllHotels()
        {
            IEnumerable<Hotel> listeHotels = _service.GetAllHotels();
            return _mapper.Map<IEnumerable<HotelsDTOOut>>(listeHotels);
        }

        public IEnumerable<HotelsDTOOut> GetAllHotelsAvecChambres()
        {
            IEnumerable<Hotel> listeHotelsAvecChambres = _service.GetAllHotels();
            return _mapper.Map<IEnumerable<HotelsDTOOut>>(listeHotelsAvecChambres);
        }


        public HotelsDTOOut GetHotelById(int id)
        {
            Hotel hotel = _service.GetHotelById(id);

            return _mapper.Map<HotelsDTOOut>(hotel);
        }

        public void CreateHotel(HotelsDTOIn obj)
        {
            Hotel hotel = _mapper.Map<Hotel>(obj);
            _service.AddHotel(hotel);
        }


        public ActionResult UpdateHotel(int id, HotelsDTOIn obj)
        {
            Hotel objFromRepo = _service.GetHotelById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateHotel(objFromRepo);
            return NoContent();
        }



        public ActionResult DeleteHotel(int id)
        {
            Hotel obj = _service.GetHotelById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteHotel(obj);
            return NoContent();
        }


    }
}
