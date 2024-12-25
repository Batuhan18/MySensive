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
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        public EfUserDal(SensiveContext context) : base(context)
        {
        }
    }
}
