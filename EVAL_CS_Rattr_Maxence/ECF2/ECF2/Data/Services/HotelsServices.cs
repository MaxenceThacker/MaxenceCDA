using ECF2.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF2.Data.Services
{
    class HotelsServices
    {

        private readonly Ecf2Context _context;

        public HotelsServices(Ecf2Context context)
        {
            _context = context;
        }

        public void AddHotel(Hotel obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Hotels.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteHotel(Hotel obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Hotels.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Hotel> GetAllHotels()
        {
            return _context.Hotels.Include("ListeChambres").ToList();
        }

        public Hotel GetHotelById(int id)
        {
            return _context.Hotels.Include("ListeChambres").FirstOrDefault(obj => obj.IdHotel == id);
        }

        public void UpdateHotel(Hotel obj)
        {

            _context.SaveChanges();
        }


    }
}
