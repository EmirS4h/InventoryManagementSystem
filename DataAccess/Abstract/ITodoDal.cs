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
        // Butun Todolari getir
        List<Todo> GetAllTodo();

        // Projeye Id'ye gore Todo getir
        List<Todo> GetAllByProject(int projectId);

        // Id'ye gore Todo getir
        Todo GetTodo(int id);

        // Todo ekle
        void Add(Todo todo);

        // Todo sil
        void Delete(Todo todo);

        // Todo guncelle
        void Update(Todo todo);
    }
}
