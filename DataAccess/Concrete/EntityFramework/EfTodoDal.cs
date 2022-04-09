using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    // Todo ile ilgili veri tabani islemlerini gerceklestirir
    public class EfTodoDal : EfEntityRepositoryBase<Todo, SqliteContext>, ITodoDal
    {
        public List<TodoDetailDto> GetTodoDetails()
        {
            using (SqliteContext context = new SqliteContext())
            {
                var res = from t in context.Todos
                          join p in context.Projects
                          on t.ProjectId equals p.Id
                          select new TodoDetailDto { ProjectName = p.ProjectName };
                return res.ToList();
            }
        }
    }
}
