﻿using Aviation.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aviation.Data.Services
{
    public class AvionServices
    {

        private readonly aviationContext _context;

        public AvionServices(aviationContext context)
        {
            _context = context;
        }

        public void AddAvion(Avion obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Avions.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAvion(Avion obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Avions.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Avion> GetAllAvion()
        {
            return _context.Avions.ToList();
        }

        public Avion GetAvionById(int id)
        {
            return _context.Avions.FirstOrDefault(obj => obj.IdAvion == id);
        }

        public void UpdateAvion(Avion obj)
        {
            _context.SaveChanges();
        }


    }
}
