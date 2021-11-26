using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var liste = (from c in _context.Client
                         join v in _context.Voiture
                         on c.IdClient equals v.IdVoiture
                         select new Client
                         {
                             IdClient = c.IdClient,
                             Nom = e1.Nom,
                             IdVoiture = v.IdVoiture,
                             Client = c
                         }).ToList();
            return liste;
        }
}
