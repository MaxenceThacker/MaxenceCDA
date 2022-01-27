using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Services
{
    public class UtilisateurServices
    {
        private readonly MyDbContext _context;

        public UtilisateurServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddUtilisateur(Utilisateur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Utilisateurs.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteUtilisateur(Utilisateur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Utilisateurs.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Utilisateur> GetAllUtilisateur()
        {
            return _context.Utilisateurs.ToList();
        }

        public Utilisateur GetUtilisateurById(int id)
        {
            return _context.Utilisateurs.FirstOrDefault(obj => obj.IdUtilisateur == id);
        }

        public void UpdateUtilisateur(Utilisateur obj)
        {
            _context.SaveChanges();
        }


    }
}
