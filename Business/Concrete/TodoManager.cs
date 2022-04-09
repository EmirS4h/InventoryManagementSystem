using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    // Todo ile ilgili Kontrolleri yapar
    public class TodoManager : ITodoService
    {
        // Kullanilacak DataAccessLayer
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public List<Todo> GetAll()
        {
            return _todoDal.GetAll();
        }
    }
}
