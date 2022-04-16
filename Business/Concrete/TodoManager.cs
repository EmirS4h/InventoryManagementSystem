using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public void Add(Todo todo)
        {
            _todoDal.Add(todo);
        }

        public List<Todo> GetAll()
        {
            return _todoDal.GetAll();
        }

        public List<Todo> GetAllTodosByProjectId(int id)
        {
            return _todoDal.GetAll(t => t.ProjectId == id);
        }
    }
}
