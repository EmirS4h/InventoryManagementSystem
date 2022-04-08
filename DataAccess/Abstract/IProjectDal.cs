using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Proje ile ilgili veri tabani operasyonlarini icerir
    public interface IProjectDal
    {
        // Butun Projeleri getir
        List<Project> GetAll();

        // Id'ye gore bir Proje getir
        Project GetById(int id);

        // Proje ekle
        void Add(Project project);

        // Proje sil
        void Delete(Project project);

        // Proje guncelle
        void Update(Project project);
    }
}
