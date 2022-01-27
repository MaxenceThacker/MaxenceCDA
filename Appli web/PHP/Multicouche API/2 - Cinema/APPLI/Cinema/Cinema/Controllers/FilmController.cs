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
    public class FilmController : ControllerBase
    {
        private readonly FilmServices _service;
        private readonly IMapper _mapper;

        public FilmController(FilmServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        //GET api/Film
        
        [HttpGet]
        public ActionResult<IEnumerable<FilmDTOOut>> GetAllFilm()
        {
            IEnumerable<Film> listeFilm = _service.GetAllFilm();
            return Ok(_mapper.Map<IEnumerable<FilmDTOOut>>(listeFilm));
        }

        //GET api/Film/{i}
        
        [HttpGet("{id}", Name = "GetFilmById")]
        public ActionResult<FilmDTOOut> GetFilmById(int id)
        {
            Film commandItem = _service.GetFilmById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<FilmDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Film
        
        [HttpPost]
        public ActionResult<FilmDTOIn> CreateFilm(FilmDTOOut obj)
        {
            _service.AddFilm(_mapper.Map<Film>(obj));
            return CreatedAtRoute(nameof(GetFilmById), new { Id = obj.IdFilm }, obj);
        }

        //POST api/Film/{id}
        
        [HttpPut("{id}")]
        public ActionResult UpdateFilm(int id, FilmDTOOut obj)
        {
            Film objFromRepo = _service.GetFilmById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateFilm(objFromRepo);
            return NoContent();
        }



        //DELETE api/Film/{id}
        
        [HttpDelete("{id}")]
        public ActionResult DeleteFilm(int id)
        {
            Film obj = _service.GetFilmById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteFilm(obj);
            return NoContent();
        }


    }
}
