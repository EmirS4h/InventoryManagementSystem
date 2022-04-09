using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProjectDal : IProjectDal
    {
        // Proje Ekle
        public void Add(Project entity)
        {
            using (SqliteContext sqliteContext = new SqliteContext()) // is bitince baglantiyi kapat
            {
                var entityToAdd = sqliteContext.Entry(entity); // eklenilecek nesneyi al
                entityToAdd.State = EntityState.Added; // ekle
                sqliteContext.SaveChanges(); // islemleri gerceklestir
            }
        }

        // Proje Sil
        public void Delete(Project entity)
        {
            using (SqliteContext sqliteContext = new SqliteContext()) // is bitince baglantiyi kapat
            {
                var entityToDelete = sqliteContext.Entry(entity); // silinecek nesneyi al
                entityToDelete.State = EntityState.Deleted; // sil
                sqliteContext.SaveChanges(); // islemleri gerceklestir
            }
        }

        // Proje Getir
        public Project Get(Expression<Func<Project, bool>> filter)
        {
            using (SqliteContext sqliteContext = new SqliteContext())
            {
                return sqliteContext.Set<Project>().SingleOrDefault(filter);
            }
        }

        // Projeleri Getir
        public List<Project> GetAll(Expression<Func<Project, bool>> filter = null)
        {
            using (SqliteContext sqliteContext = new SqliteContext())
            {
                // filtre yoksa butun projeleri getir eger filtre varsa filtreye uyan proje/projeleri getir
                return filter == null ?
                    sqliteContext.Set<Project>().ToList() :
                    sqliteContext.Set<Project>().Where(filter).ToList();
            }
        }

        // Proje Guncelle
        public void Update(Project entity)
        {
            using (SqliteContext sqliteContext = new SqliteContext()) // is bitince baglantiyi kapat
            {
                var entityToUpdate = sqliteContext.Entry(entity); // guncellenecek nesneyi al
                entityToUpdate.State = EntityState.Modified; // guncelle
                sqliteContext.SaveChanges(); // islemleri gerceklestir
            }
        }
    }
}
