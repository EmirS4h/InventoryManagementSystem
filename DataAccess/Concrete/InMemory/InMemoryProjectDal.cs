using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    // Project ile ilgili veri tabani islemlerini gerceklestirir
    public class InMemoryProjectDal : IProjectDal
    {
        List<Project> _projects;

        public InMemoryProjectDal()
        {
            _projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    ProjectName = "First Project",
                    TotalTodosCompleted = 0,
                    TotalTodosInProject = 0,
                },
                new Project
                {
                    Id = 2,
                    ProjectName = "Second Project",
                    TotalTodosCompleted = 3,
                    TotalTodosInProject = 10,
                },
                new Project
                {
                    Id = 3,
                    ProjectName = "Third Project",
                    TotalTodosCompleted = 8,
                    TotalTodosInProject = 23,
                },
                new Project
                {
                    Id = 4,
                    ProjectName = "Fourth Project",
                    TotalTodosCompleted = 1,
                    TotalTodosInProject = 4,
                },
                new Project
                {
                    Id = 5,
                    ProjectName = "Fifth Project",
                    TotalTodosCompleted = 10,
                    TotalTodosInProject = 10,
                },
            };
        }

        public void Add(Project project)
        {
            throw new NotImplementedException();
        }

        public void Delete(Project project)
        {
            throw new NotImplementedException();
        }

        public Project Get(Expression<Func<Project, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll(Expression<Func<Project, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
