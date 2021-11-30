using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Dtos;
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

        public void AddVoitures(Voiture v1)
        {
            if (v1 == null)
            {
                throw new ArgumentNullException(nameof(v1));
            }
            _context.Voitures.Add(v1);
            _context.SaveChanges();
        }

        public IEnumerable<Voiture> GetAllVoitures()
        {
            var ent = (from v1 in _context.Voitures
                       join c1 in _context.Clients
                       on v1.IdClient equals c1.IdClient
                       select new Voiture
                       {
                           IdVoiture = v1.IdVoiture,
                           Marque = v1.Marque,
                           Modele = v1.Modele,
                           Couleur = v1.Couleur,
                           IdClient = c1.IdClient,
                           Clt = c1

                       }).ToList();
            return ent;
        }

        public Voiture GetVoitureById(int id)
        {
            var ent = (from v1 in _context.Voitures
                         join c1 in _context.Clients
                         on v1.IdClient equals c1.IdClient
                         select new Voiture
                         {
                             IdVoiture = v1.IdVoiture,
                             Marque = v1.Marque,
                             Modele = v1.Modele,
                             Couleur = v1.Couleur,
                             IdClient = c1.IdClient,
                             Clt = c1

                         }).FirstOrDefault(v => v.IdVoiture == id); 
            return ent;
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

        public void UpdateVoiture(Voiture v1)
        {
            if (v1 == null)
            {
                throw new ArgumentNullException(nameof(v1));
            }
            var voiture = new Voiture()
            {
                IdVoiture = v1.IdVoiture,
                Marque = v1.Marque,
                Modele = v1.Modele,
                Couleur = v1.Couleur,
                IdClient = v1.IdClient,
            };
            _context.Update(voiture);
            _context.SaveChanges();
        }
    }
}
