using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Services
{
    public class SeanceServices
    {
        private readonly MyDbContext _context;

        public SeanceServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddSeance(Seance obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Seances.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteSeance(Seance obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Seances.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Seance> GetAllSeance()
        {
            return _context.Seances.ToList();
        }

        public Seance GetSeanceById(int id)
        {
            return _context.Seances.FirstOrDefault(obj => obj.IdSeance == id);
        }

        public void UpdateSeance(Seance obj)
        {
            _context.SaveChanges();
        }


    }
}
