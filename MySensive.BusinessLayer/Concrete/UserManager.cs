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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TDelete(int id)
        {
            _userDal.Delete(id);
        }

        public List<User> TGetAll()
        {
            return _userDal.GetAll();
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void TInsert(User entity)
        {
            _userDal.Insert(entity);
        }

        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }
    }
}
