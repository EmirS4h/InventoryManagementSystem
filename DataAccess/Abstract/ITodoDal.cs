using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // Todo ile ilgili veri tabani operasyonlarini icerir
    public interface ITodoDal : IEntityRepository<Todo>
    {
        
    }
}
