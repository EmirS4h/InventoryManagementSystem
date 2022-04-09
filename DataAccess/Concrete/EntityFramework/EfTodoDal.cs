using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Todo ile ilgili veri tabani islemlerini gerceklestirir
    internal class EfTodoDal : ITodoDal
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
            throw new NotImplementedException();
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
