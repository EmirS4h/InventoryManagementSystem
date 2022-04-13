using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.Get(user => user.Id == id);
        }
        public User GetByUsername(string name)
        {
            return _userDal.Get(user => user.Username == name);
        }

        public void Add(User newUser)
        {
            _userDal.Add(newUser);
        }
    }
}
