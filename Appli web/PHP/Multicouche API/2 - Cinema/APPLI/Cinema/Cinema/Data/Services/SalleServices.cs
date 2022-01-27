using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Services
{
    public class SalleServices
    {
        private readonly MyDbContext _context;

        public SalleServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddSalle(Salle obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Salles.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteSalle(Salle obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Salles.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Salle> GetAllSalle()
        {
            return _context.Salles.ToList();
        }

        public Salle GetSalleById(int id)
        {
            return _context.Salles.FirstOrDefault(obj => obj.IdSalle == id);
        }

        public void UpdateSalle(Salle obj)
        {
            _context.SaveChanges();
        }


    }
}
