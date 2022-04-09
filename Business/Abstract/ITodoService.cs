using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    // Todo ile ilgili kontrol operasyonlarini tutar
    public interface ITodoService
    {
        List<Todo> GetAll();
    }
}
