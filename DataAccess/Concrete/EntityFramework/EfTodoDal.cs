using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    // Todo ile ilgili veri tabani islemlerini gerceklestirir
    internal class EfTodoDal : EfEntityRepositoryBase<Todo, SqliteContext>, ITodoDal
    {
        
    }
}
