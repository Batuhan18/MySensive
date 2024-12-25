using MySensive.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        List<Article> TArticleListWithCategoryAndUser();
        List<Article> TArticleListWithCategory();
        public Article TGetLastArticle();
        List<Article> TGetArticlesByAppUserId(int id);
        public Article TGetByIdWithCategory(int id);
    }
}
