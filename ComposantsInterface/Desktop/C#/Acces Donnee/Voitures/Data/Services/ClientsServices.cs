
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Models;

namespace Voitures.Data.Services
{
    public class ClientsServices
    {
        private readonly MyDbContext _context;
        public ClientsServices(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAllClient()
        {
            return _context.Clients.ToList();
        }

    }  
}
