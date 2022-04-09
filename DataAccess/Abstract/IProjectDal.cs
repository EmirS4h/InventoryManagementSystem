using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // Proje ile ilgili veri tabani operasyonlarini icerir
    public interface IProjectDal : IEntityRepository<Project>
    {
        
    }
}
