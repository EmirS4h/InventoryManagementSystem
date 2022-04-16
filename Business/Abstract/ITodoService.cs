using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    // Todo ile ilgili kontrol operasyonlarini tutar
    public interface ITodoService
    {
        List<Todo> GetAll();
        List<Todo> GetAllTodosByProjectId(int id);
        void Add(Todo todo);
    }
}
