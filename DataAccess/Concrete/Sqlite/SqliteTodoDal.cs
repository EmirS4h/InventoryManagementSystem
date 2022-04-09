using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Sqlite
{
    // Todo ile ilgili veri tabani operasyonlarini gerceklestirir
    public class SqliteTodoDal : ITodoDal
    {
        public void Add(Todo todo)
        {
            throw new NotImplementedException();
        }

        public void Delete(Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllByProject(int projectId)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllTodo()
        {
            return new List<Todo>() { new Todo { TodoText="sqlite todo"} };
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
