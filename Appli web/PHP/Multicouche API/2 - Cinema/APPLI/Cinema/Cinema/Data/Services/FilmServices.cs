using Cinema.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Data.Services
{
    public class FilmServices
    {
        private readonly MyDbContext _context;

        public FilmServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddFilm(Film obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Films.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteFilm(Film obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Films.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Film> GetAllFilm()
        {
            return _context.Films.ToList();
        }

        public Film GetFilmById(int id)
        {
            return _context.Films.FirstOrDefault(obj => obj.IdFilm == id);
        }

        public void UpdateFilm(Film obj)
        {
            _context.SaveChanges();
        }


    }
}
