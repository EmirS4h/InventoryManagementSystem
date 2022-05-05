using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ItemsManager : IItemsService
    {
        IItemsDal _itemsDal;

        public ItemsManager(IItemsDal itemsDal)
        {
            _itemsDal = itemsDal;
        }

        public List<Items> GetAll()
        {
            throw new NotImplementedException();
        }

        public Items GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Items GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
