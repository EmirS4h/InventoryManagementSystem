using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProjectService
    {
        List<Project> GetAll();
        List<Project> GetAllByUserId(int id);
        List<Project> GetAllByTodoCount(int min,int max);
        List<Project> GetAllByMinTodoCount(int min);
        List<Project> GetAllByMaxTodoCount(int max);
        bool Add(Project project);
        void Delete(Project project);
    }
}
