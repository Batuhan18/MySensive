using MySensive.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.DataAccessLayer.Abstract
{
    public interface IArticleDal : IRepository<Article>
    {
        List<Article> GetArticlesByUserId(int id);
        Article GetByIdWithCategory(int id);
        Article GetLastArticle();
    }
}
