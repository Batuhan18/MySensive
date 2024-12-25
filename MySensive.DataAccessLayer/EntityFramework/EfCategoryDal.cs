using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SensiveContext context) : base(context)
        {
        }
        public List<Category> GetAll()
        {
            var c = new SensiveContext();
            var listele = c.Categories.ToList();
            return listele;
        }
    }
}
