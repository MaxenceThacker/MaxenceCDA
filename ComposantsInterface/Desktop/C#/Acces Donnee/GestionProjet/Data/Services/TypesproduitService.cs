using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Services
{
    class TypesproduitService
    {

        private readonly MyDbContext _context;

        public TypesproduitService(MyDbContext context)
        {
            _context = context;
        }

        public void AddTypesproduit(Typesproduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Typesproduits.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTypesproduit(Typesproduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Typesproduits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Typesproduit> GetAllTypesproduit()
        {
            return _context.Typesproduits.ToList();
        }

        public Typesproduit GetTypesproduitById(int id)
        {
            return _context.Typesproduits.FirstOrDefault(obj => obj.IdTypesProduits == id);
        }

        public void UpdateTypesproduit(Typesproduit obj)
        {
            _context.SaveChanges();
        }


    }
}
