using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // Todo ile ilgili kontrol operasyonlarini tutar
    public interface ITodoService
    {
        List<Todo> GetAll();
    }
}
