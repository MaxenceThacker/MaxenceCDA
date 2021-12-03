using GestionProjet.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Data.Services
{
    class ArticleService
    {

        private readonly MyDbContext _context;

        public ArticleService(MyDbContext context)
        {
            _context = context;
        }

        public void AddArticle(Article obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArticle(Article obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Article> GetAllArticle()
        {
            return _context.Articles.ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(obj => obj.IdArticles == id);
        }

        public void UpdateArticle(Article obj)
        {
            _context.SaveChanges();
        }


    }
}
