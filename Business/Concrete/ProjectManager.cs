using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        // Kullanilacak DataAccessLayer
        IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        // Proje ekle
        public bool Add(Project project)
        {
            var projectExist = _projectDal.Get(p=> p.Id == project.Id);
            if (projectExist is not null) return false;
            _projectDal.Add(project);
            return true;
        }

        public void Delete(Project project)
        {
            _projectDal.Delete(project);
        }

        // Butun Projeleri getir
        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        // Max Todo sayisini gecmeyen Projeleri getir
        public List<Project> GetAllByMaxTodoCount(int max)
        {
            return _projectDal.GetAll(p => p.TotalTodosInProject <= max);
        }

        // Min Todo sayisina sahip Projeleri getir
        public List<Project> GetAllByMinTodoCount(int min)
        {
            return _projectDal.GetAll(p => p.TotalTodosInProject >= min);
        }

        // Belirlenen 2 sayi arasindaki Todo sayisina sahip Projeleri getir
        public List<Project> GetAllByTodoCount(int min, int max)
        {
            return _projectDal.GetAll(p=>p.TotalTodosInProject >= min && p.TotalTodosInProject <= max);
        }

        // Kullanici Id'sine ait butun Projeleri getir
        public List<Project> GetAllByUserId(int id)
        {
            return _projectDal.GetAll(p => p.UserId == id);
        }
    }
}
