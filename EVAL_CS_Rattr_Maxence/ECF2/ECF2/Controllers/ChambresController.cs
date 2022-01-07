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
    class ChambresController : ControllerBase
    {
        private readonly ChambresServices _service;
        private readonly IMapper _mapper;


        public ChambresController(Ecf2Context context)
        {
            _service = new ChambresServices(context);
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<ChambresProfiles>();
                cfg.AddProfile<HotelsProfiles>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<ChambresDTOOut> GetAllChambres()
        {
            IEnumerable<Chambre> listeChambres = _service.GetAllChambres();
            return _mapper.Map<IEnumerable<ChambresDTOOut>>(listeChambres);
        }

        public IEnumerable<ChambresDTOOutAvecHotel> GetAllChambresAvecHotel()
        {
            IEnumerable<Chambre> listeChambresAvecHotel = _service.GetAllChambres();
            return _mapper.Map<IEnumerable<ChambresDTOOutAvecHotel>>(listeChambresAvecHotel);
        }


        public ChambresDTOOutAvecHotel GetChambreById(int id)
        {
            Chambre chambre = _service.GetChambreById(id);

            return _mapper.Map<ChambresDTOOutAvecHotel>(chambre);
        }

        public void CreateChambre(ChambresDTOIn obj)
        {
            Chambre chambre = _mapper.Map<Chambre>(obj);
            _service.AddChambre(chambre);
        }


        public ActionResult UpdateChambre(int id, ChambresDTOIn obj)
        {
            Chambre objFromRepo = _service.GetChambreById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateChambre(objFromRepo);
            return NoContent();
        }



        public ActionResult DeleteChambre(int id)
        {
            Chambre obj = _service.GetChambreById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteChambre(obj);
            return NoContent();
        }
    }
}
