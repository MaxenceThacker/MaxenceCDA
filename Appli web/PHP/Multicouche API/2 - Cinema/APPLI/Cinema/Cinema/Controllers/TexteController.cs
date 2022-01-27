using AutoMapper;
using Cinema.Data.DTOs;
using Cinema.Data.Models;
using Cinema.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TexteController : ControllerBase
    {
        private readonly TexteServices _service;
        private readonly IMapper _mapper;

        public TexteController(TexteServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Texte

        [HttpGet]
        public ActionResult<IEnumerable<TexteDTOOut>> GetAllTexte()
        {
            IEnumerable<Texte> listeTexte = _service.GetAllTexte();
            return Ok(_mapper.Map<IEnumerable<TexteDTOOut>>(listeTexte));
        }

        //GET api/Texte/{i}

        [HttpGet("{id}", Name = "GetTexteById")]
        public ActionResult<TexteDTOOut> GetTexteById(int id)
        {
            Texte commandItem = _service.GetTexteById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<TexteDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Texte

        [HttpPost]
        public ActionResult<TexteDTOIn> CreateTexte(TexteDTOOut obj)
        {
            _service.AddTexte(_mapper.Map<Texte>(obj));
            return CreatedAtRoute(nameof(GetTexteById), new { Id = obj.IdTexte }, obj);
        }

        //POST api/Texte/{id}

        [HttpPut("{id}")]
        public ActionResult UpdateTexte(int id, TexteDTOOut obj)
        {
            Texte objFromRepo = _service.GetTexteById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateTexte(objFromRepo);
            return NoContent();
        }



        //DELETE api/Texte/{id}

        [HttpDelete("{id}")]
        public ActionResult DeleteTexte(int id)
        {
            Texte obj = _service.GetTexteById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteTexte(obj);
            return NoContent();
        }


    }
}
