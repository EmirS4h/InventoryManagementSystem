using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    // Ortak islemler
    public class EfEntityRepositoryBase<T, U> : IEntityRepository<T>
        where T : class, IEntity, new()
        where U : DbContext, new()
    {
        // Ekle
        public void Add(T entity)
        {
            using (U context = new U()) // is bitince baglantiyi kapat
            {
                var entityToAdd = context.Entry(entity); // eklenilecek nesneyi al
                entityToAdd.State = EntityState.Added; // ekle
                context.SaveChanges(); // islemleri gerceklestir
            }
        }

        // Sil
        public void Delete(T entity)
        {
            using (U context = new U()) // is bitince baglantiyi kapat
            {
                var entityToDelete = context.Entry(entity); // silinecek nesneyi al
                entityToDelete.State = EntityState.Deleted; // sil
                context.SaveChanges(); // islemleri gerceklestir
            }
        }

        // Getir
        public T Get(Expression<Func<T, bool>> filter)
        {
            using (U context = new U())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        // Getir Cogul
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (U context = new U())
            {
                // filtre yoksa butun entityleri getir eger filtre varsa filtreye uyan entity/entityleri getir
                return filter == null ?
                    context.Set<T>().ToList() : // filtre yok ise
                    context.Set<T>().Where(filter).ToList(); // filtre var ise
            }
        }

        // Guncelle
        public void Update(T entity)
        {
            using (U context = new U()) // is bitince baglantiyi kapat
            {
                var entityToUpdate = context.Entry(entity); // guncellenecek nesneyi al
                entityToUpdate.State = EntityState.Modified; // guncelle
                context.SaveChanges(); // islemleri gerceklestir
            }
        }
    }
}
