using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    // Todo ile ilgili ozel veri tabani operasyonlarini icerir
    public interface ITodoDal : IEntityRepository<Todo>
    {
    }
}
