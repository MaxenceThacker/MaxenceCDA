using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aviation.Data.Services
{
    public class ApparteniragenceServices
    {

        private readonly aviationContext _context;

        public ApparteniragenceServices(aviationContext context)
        {
            _context = context;
        }

        public void AddApparteniragence(Apparteniragence obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Apparteniragences.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteApparteniragence(Apparteniragence obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Apparteniragences.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Apparteniragence> GetAllApparteniragence()
        {
            return _context.Apparteniragences.ToList();
        }

        public Apparteniragence GetApparteniragenceById(int id)
        {
            return _context.Apparteniragences.FirstOrDefault(obj => obj.IdAppartenirAgences == id);
        }

        public void UpdateApparteniragence(Apparteniragence obj)
        {
            _context.SaveChanges();
        }


    }
}
