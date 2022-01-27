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
    public class SalleController : ControllerBase
    {
        private readonly SalleServices _service;
        private readonly IMapper _mapper;

        public SalleController(SalleServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Salle

        [HttpGet]
        public ActionResult<IEnumerable<SalleDTOOut>> GetAllSalle()
        {
            IEnumerable<Salle> listeSalle = _service.GetAllSalle();
            return Ok(_mapper.Map<IEnumerable<SalleDTOOut>>(listeSalle));
        }

        //GET api/Salle/{i}

        [HttpGet("{id}", Name = "GetSalleById")]
        public ActionResult<SalleDTOOut> GetSalleById(int id)
        {
            Salle commandItem = _service.GetSalleById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<SalleDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Salle

        [HttpPost]
        public ActionResult<SalleDTOIn> CreateSalle(SalleDTOOut obj)
        {
            _service.AddSalle(_mapper.Map<Salle>(obj));
            return CreatedAtRoute(nameof(GetSalleById), new { Id = obj.IdSalle }, obj);
        }

        //POST api/Salle/{id}

        [HttpPut("{id}")]
        public ActionResult UpdateSalle(int id, SalleDTOOut obj)
        {
            Salle objFromRepo = _service.GetSalleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateSalle(objFromRepo);
            return NoContent();
        }



        //DELETE api/Salle/{id}

        [HttpDelete("{id}")]
        public ActionResult DeleteSalle(int id)
        {
            Salle obj = _service.GetSalleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteSalle(obj);
            return NoContent();
        }


    }
}
