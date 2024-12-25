using MySensive.BusinessLayer.Abstract;
using MySensive.DataAccessLayer.Abstract;
using MySensive.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySensive.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _comentDal;

        public CommentManager(ICommentDal comentDal)
        {
            _comentDal = comentDal;
        }

        public List<Comment> GetComments()
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            _comentDal.Delete(id);
        }

        public List<Comment> TGetAll()
        {
            return _comentDal.GetAll();
        }

        public Comment TGetById(int id)
        {
            return _comentDal.GetById(id);
        }

        public List<Comment> TGetCommentsByArticleId(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Comment entity)
        {
            _comentDal.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            _comentDal.Update(entity);
        }
    }
}
