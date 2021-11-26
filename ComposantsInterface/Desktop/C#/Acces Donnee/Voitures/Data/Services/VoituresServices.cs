using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Models;

namespace Voitures.Data.Services
{
    public class VoituresServices
    {
        private readonly MyDbContext _context; 
        public VoituresServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddVoitures(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }
            _context.Voitures.Add(v);
            _context.SaveChanges();
        }

        public void DeleteVoitures(Voiture v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v));
            }
            _context.Voitures.Remove(v);
            _context.SaveChanges();
        } 

        public IEnumerable<Voiture> GetAllVoitures()
        {
           var liste = (f) ;
        }

        public Voiture GetVoitureById(int id)
        {
            return _context.Voitures.FirstOrDefault(v => v.IdVoiture == id);
        }

        public void UpdateVoiture(Voiture v)
        {

        }
    }
}
