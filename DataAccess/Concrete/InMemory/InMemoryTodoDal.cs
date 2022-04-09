using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    // Todo ile ilgili veri tabani islemlerini gerceklestirir
    public class InMemoryTodoDal : ITodoDal
    {
        List<Todo> _todos;

        public InMemoryTodoDal()
        {
            _todos = new List<Todo>
            {
                new Todo
                {
                    Id = 1,
                    ProjectId = 1,
                    Completed = 0,
                    TodoText = "First Todo of Project 1",
                    CreatedDate = "08.04.2022",
                    Priority = "Low",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 2,
                    ProjectId = 1,
                    Completed = 1,
                    TodoText = "Second Todo of Project 1",
                    CreatedDate = "08.04.2022",
                    Priority = "Medium",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 3,
                    ProjectId = 2,
                    Completed = 1,
                    TodoText = "First Todo of Project 2",
                    CreatedDate = "08.04.2022",
                    Priority = "High",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 4,
                    ProjectId = 3,
                    Completed = 0,
                    TodoText = "First Todo of Project 3",
                    CreatedDate = "08.04.2022",
                    Priority = "Medium",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 5,
                    ProjectId = 1,
                    Completed = 0,
                    TodoText = "First Todo of Project 5",
                    CreatedDate = "08.04.2022",
                    Priority = "High",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 1,
                    ProjectId = 1,
                    Completed = 0,
                    TodoText = "First Todo of Project 1",
                    CreatedDate = "08.04.2022",
                    Priority = "Low",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 2,
                    ProjectId = 1,
                    Completed = 1,
                    TodoText = "Second Todo of Project 1",
                    CreatedDate = "08.04.2022",
                    Priority = "Medium",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 3,
                    ProjectId = 2,
                    Completed = 1,
                    TodoText = "First Todo of Project 2",
                    CreatedDate = "08.04.2022",
                    Priority = "High",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 4,
                    ProjectId = 3,
                    Completed = 0,
                    TodoText = "First Todo of Project 3",
                    CreatedDate = "08.04.2022",
                    Priority = "Medium",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
                new Todo
                {
                    Id = 5,
                    ProjectId = 1,
                    Completed = 0,
                    TodoText = "First Todo of Project 5",
                    CreatedDate = "08.04.2022",
                    Priority = "High",
                    CompletedDate = "",
                    UpdatedDate = "",
                },
            };
        }

        // Todo ekle
        public void Add(Todo todo)
        {
            _todos.Add(todo);
        }

        // Todo sil
        public void Delete(Todo todo)
        {
            //foreach (Todo item in _todos)
            //{
            //    if (todo.Id == item.Id)
            //    {
            //        todoToDelete = item;
            //    }
            //}
            Todo todoToDelete = _todos.SingleOrDefault(t => t.Id == todo.Id);
            _todos.Remove(todoToDelete);
        }

        public Todo Get(Expression<Func<Todo, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAll(Expression<Func<Todo, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        // ProjeId'si uyan Todolari getir
        public List<Todo> GetAllByProject(int projectId)
        {
            return _todos.Where(t => t.ProjectId == projectId).ToList();
        }

        // Butun Todolari getir
        public List<Todo> GetAllTodo()
        {
            return _todos;
        }

        // Id'ye gore Todo getir
        public Todo GetTodo(int id)
        {
            return _todos.SingleOrDefault(t => t.Id == id);
        }

        public List<TodoDetailDto> GetTodoDetails()
        {
            throw new NotImplementedException();
        }

        // Todo guncelle
        public void Update(Todo todo)
        {
            Todo todoToUpdate = _todos.SingleOrDefault(t => t.Id == todo.Id);

            todoToUpdate.TodoText = todo.TodoText;
            todoToUpdate.CreatedDate = todo.CreatedDate;
            todoToUpdate.Priority = todo.Priority;
            todoToUpdate.CompletedDate = todo.CompletedDate;
            todoToUpdate.UpdatedDate = todo.UpdatedDate;
            todoToUpdate.Completed = todo.Completed;
        }
    }
}
