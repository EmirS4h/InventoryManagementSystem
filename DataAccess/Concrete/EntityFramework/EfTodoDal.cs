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
    }
}
