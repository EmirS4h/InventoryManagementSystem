using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UsersManager : IUserService
    {
        IUserDal _userDal;

        public UsersManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<Users> GetAll()
        {
            return _userDal.GetAll();
        }

        public Users GetById(int id)
        {
            return _userDal.Get(user => user.Id == id);
        }
        public Users GetByName(string name)
        {
            return _userDal.Get(user => user.Name == name);
        }

        public bool Add(Users newUser)
        {
            Users userExist = GetByName(newUser.Name);
            if (userExist != null) return false;
            _userDal.Add(newUser);
            return true;
        }

        public void Update(Users user)
        {
            _userDal.Update(user);
        }

        public void Delete(Users user)
        {
            _userDal.Delete(user);
        }
    }
}
