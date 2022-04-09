using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Ortak Operasyonlari icerir
    // T referans turunde olmalı - IEntity'i implemente etmeli
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // Hepsini getir
        List<T> GetAll(Expression<Func<T,bool>> filter = null); // Filtre olmasada olur

        // Bir tane getir
        T Get(Expression<Func<T, bool>> filter); // Filtre zorunlu

        // Ekle
        void Add(T entity);

        // Sil
        void Delete(T entity);

        // Guncelle
        void Update(T entity);
    }
}
