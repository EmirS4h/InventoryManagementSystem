using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Todo ile ilgili veri tabani operasyonlarini icerir
    public interface ITodoDal
    {
        List<Todo> GetAllTodo();
        List<Todo> GetAllByProject(int projectId);
        Todo GetTodo(int id);
        void Add(Todo todo);
        void Delete(Todo todo);
        void Update(Todo todo);
    }
}
