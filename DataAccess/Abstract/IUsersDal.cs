using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // User ile ilgili veri tabani operasyonlarini icerir
    public interface IUserDal : IEntityRepository<Users>
    {
    }
}
