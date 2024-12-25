using Microsoft.EntityFrameworkCore;
using MySensive.BusinessLayer.Abstract;
using MySensive.DataAccessLayer.Abstract;
using MySensive.DataAccessLayer.Context;
using MySensive.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public List<Article> TArticleListWithCategory()
        {
            throw new NotImplementedException();
        }

        public List<Article> TArticleListWithCategoryAndUser()
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public List<Article> TGetArticlesByAppUserId(int id)
        {
            return _articleDal.GetArticlesByUserId(id);
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public Article TGetByIdWithCategory(int id)
        {
            return _articleDal.GetByIdWithCategory(id);
        }

        public Article TGetLastArticle()
        {
            return _articleDal.GetLastArticle();
        }

        public void TInsert(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public void TUpdate(Article entity)
        {
            if (entity.Description != "" && entity.Title.Length >= 3)
            {
                _articleDal.Update(entity);
            }
        }
    }
}
