using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Dtos;
using Voitures.Data.Services;

namespace Voitures.Controllers
{
    [Route("api/Clients")]

    [ApiController]
    public class ClientsControllers
    {
        private readonly ClientsServices _service;
        private readonly IMapper _mapper;
        public ClientsControllers(ClientsServices service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VoituresDtosIn>> GetAllClient()
        {
            IEnumerable<Client> listeClients = _service.GetAllClient();
            return Ok(_mapper.Map<IEnumerable<ClientsDtosIn>>(listeClients));
        }
    }
}
