using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        // User Ekle
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        // User Sil
        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        // User Getir
        public User Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        // User'lari Getir
        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        // User Guncelle
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
