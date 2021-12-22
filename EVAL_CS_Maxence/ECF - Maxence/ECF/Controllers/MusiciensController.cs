using AutoMapper;
using ECF.Data;
using ECF.Data.DTOs;
using ECF.Data.Models;
using ECF.Data.Profiles;
using ECF.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Controllers
{
    class MusiciensController : ControllerBase
    {
        private readonly MusiciensServices _service;
        private readonly IMapper _mapper;


        public MusiciensController(ECFContext context)
        {
            _service = new MusiciensServices(context);
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MusiciensProfiles>();
                cfg.AddProfile<GroupesProfiles>();
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<MusiciensDTOOutAvecGroupe> GetAllMusiciens()
        {
            IEnumerable<Musicien> listeMusiciens = _service.GetAllMusiciens();
            return _mapper.Map<IEnumerable<MusiciensDTOOutAvecGroupe>>(listeMusiciens);
        }


        public MusiciensDTOOutAvecGroupe GetMusicienById(int id)
        {
            Musicien membre = _service.GetMusicienById(id);

            return _mapper.Map<MusiciensDTOOutAvecGroupe>(membre);
        }

        public void CreateMusicien(MusiciensDTOIn obj)
        {
            Musicien musicien = _mapper.Map<Musicien>(obj);
            _service.AddMusicien(musicien);
        }


        public ActionResult UpdateMusicien(int id, MusiciensDTOIn obj)
        {
            Musicien objFromRepo = _service.GetMusicienById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateMusicien(objFromRepo);
            return NoContent();
        }



        public ActionResult DeleteMusicien(int id)
        {
            Musicien obj = _service.GetMusicienById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteMusicien(obj);
            return NoContent();
        }
    }
}

