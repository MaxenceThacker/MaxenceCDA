using AutoMapper;
using ECF.Data;
using ECF.Data.DTOs;
using ECF.Data.Models;
using ECF.Data.Profiles;
using ECF.Data.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Controllers
{
    class GroupesController : ControllerBase
    {

        private readonly GroupesServices _service;
        private readonly IMapper _mapper;


        public GroupesController(ECFContext context)
        {
            _service = new GroupesServices(context);
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<GroupesProfiles>();
                cfg.AddProfile<MusiciensProfiles>();
            });
            _mapper = config.CreateMapper();
        }

      
        public IEnumerable<GroupesDTOOutAvecMusiciens> GetAllGroupes()
        {
            IEnumerable<Groupe> listeGroupes = _service.GetAllGroupes();
            return _mapper.Map<IEnumerable<GroupesDTOOutAvecMusiciens>>(listeGroupes);
        }


        public GroupesDTOOutAvecMusiciens GetGroupeById(int id)
        {
            Groupe membre = _service.GetGroupeById(id);
            
           return _mapper.Map<GroupesDTOOutAvecMusiciens>(membre);
        }

        public void CreateGroupe(GroupesDTOIn obj)
        {
            Groupe groupe = _mapper.Map<Groupe>(obj);
            _service.AddGroupe(groupe);
        }


        public ActionResult UpdateGroupe(int id, GroupesDTOIn obj)
        {
            Groupe objFromRepo = _service.GetGroupeById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateGroupe(objFromRepo);
            return NoContent();
        }



        public ActionResult DeleteGroupe(int id)
        {
            Groupe obj = _service.GetGroupeById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteGroupe(obj);
            return NoContent();
        }


    }
}
