using ECF2.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF2.Data.Services
{
    class ChambresServices
    {

        private readonly Ecf2Context _context;

        public ChambresServices(Ecf2Context context)
        {
            _context = context;
        }

        public void AddChambre(Chambre obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Chambres.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteChambre(Chambre obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Chambres.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Chambre> GetAllChambres()
        {
            return _context.Chambres.ToList();
        }

        public Chambre GetChambreById(int id)
        {
            return _context.Chambres.FirstOrDefault(obj => obj.IdChambre == id);
        }

        public void UpdateChambre(Chambre obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }


    }
}
