using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IItemsService
    {
        List<Items> GetAll();
        Items GetById(int id);
        Items GetByName(string name);
        void Delete(int id);
        bool Add(Items item);
        void Update(Items item);
    }
}
