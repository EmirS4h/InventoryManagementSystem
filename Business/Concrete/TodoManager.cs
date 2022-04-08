using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Kontrolleri yapar
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal=todoDal;
        }

        public List<Todo> GetAll()
        {
            return _todoDal.GetAllTodo();
        }
    }
}
