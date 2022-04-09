using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // User ile ilgili veri tabani operasyonlarini icerir
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
