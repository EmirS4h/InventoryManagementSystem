using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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

        public Todo Get(Expression<Func<Todo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAll(Expression<Func<Todo, bool>> filter = null)
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

        public List<Todo> GetAllTodosByProjectId(int id)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoDetailDto> GetTodoDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
