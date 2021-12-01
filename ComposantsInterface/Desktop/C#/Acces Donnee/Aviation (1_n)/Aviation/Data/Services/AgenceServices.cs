using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Data.Services
{
    public class AgenceServices
    {

        private readonly aviationContext _context;

        public AgenceServices(aviationContext context)
        {
            _context = context;
        }

        public void AddAgence(Agence obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Agences.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAgence(Agence obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Agences.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Agence> GetAllAgence()
        {
            return _context.Agences.ToList();
        }

        public Agence GetAgenceById(int id)
        {
            return _context.Agences.FirstOrDefault(obj => obj.IdAgence == id);
        }

        public void UpdateAgence(Agence obj)
        {
            _context.SaveChanges();
        }


    }
}
