using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using Cinema.Data.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    [EnableCors("Cinema")]
    [Route("api/[Controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly UtilisateurServices _service;
        private readonly IMapper _mapper;

        public UtilisateurController(UtilisateurServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Utilisateur

        [HttpGet]
        public ActionResult<IEnumerable<UtilisateurDTOOut>> GetAllUtilisateur()
        {
            IEnumerable<Utilisateur> listeUtilisateur = _service.GetAllUtilisateur();
            return Ok(_mapper.Map<IEnumerable<UtilisateurDTOOut>>(listeUtilisateur));
        }

        //GET api/Utilisateur/{i}

        [HttpGet("{id}", Name = "GetUtilisateurById")]
        public ActionResult<UtilisateurDTOOut> GetUtilisateurById(int id)
        {
            Utilisateur commandItem = _service.GetUtilisateurById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<UtilisateurDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Utilisateur

        [HttpPost]
        public ActionResult<UtilisateurDTOIn> CreateUtilisateur(UtilisateurDTOOut obj)
        {
            _service.AddUtilisateur(_mapper.Map<Utilisateur>(obj));
            return CreatedAtRoute(nameof(GetUtilisateurById), new { Id = obj.IdUtilisateur }, obj);
        }

        //POST api/Utilisateur/{id}

        [HttpPut("{id}")]
        public ActionResult UpdateUtilisateur(int id, UtilisateurDTOOut obj)
        {
            Utilisateur objFromRepo = _service.GetUtilisateurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateUtilisateur(objFromRepo);
            return NoContent();
        }



        //DELETE api/Utilisateur/{id}

        [HttpDelete("{id}")]
        public ActionResult DeleteUtilisateur(int id)
        {
            Utilisateur obj = _service.GetUtilisateurById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteUtilisateur(obj);
            return NoContent();
        }


    }
}
