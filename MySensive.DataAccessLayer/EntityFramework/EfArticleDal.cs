using Microsoft.EntityFrameworkCore;
using MySensive.DataAccessLayer.Abstract;
using MySensive.DataAccessLayer.Context;
using MySensive.DataAccessLayer.Repository;
using MySensive.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal

    {

        public EfArticleDal(SensiveContext context) : base(context)
        {
        }
        public List<Article> ArticleListWithCategory()
        {
            var c = new SensiveContext();
            var values = c.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndUser()
        {
            var c = new SensiveContext();
            var values = c.Articles.Include(x => x.Category).Include(y => y.User).Include(z => z.Comments).ToList();
            return values;
        }

        public List<Article> GetArticlesByUserId(int id)
        {
            var c = new SensiveContext();
            var values = c.Articles.Where(x => x.UserId == id).Include(x => x.Category).ToList();
            return values;
        }


        public Article GetByIdWithCategory(int id)
        {
            var c = new SensiveContext();
            var values = c.Articles.Where(x => x.ArticleId == id).Include(x => x.Category).FirstOrDefault();
            return values;
        }

        public Article GetLastArticle()
        {
            var c = new SensiveContext();
            var values = c.Articles.OrderByDescending(x => x.ArticleId).Take(1).FirstOrDefault();
            return values;
        }

    }
}
