using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ItemsManager : IItemsService
    {
        IItemsDal _itemsDal;

        public ItemsManager(IItemsDal itemsDal)
        {
            _itemsDal = itemsDal;
        }

        public bool Add(Items item)
        {
            Items itemExist = GetByName(item.Name);
            if (itemExist != null) return false;
            _itemsDal.Add(item);
            return true;
        }

        public void Delete(int id)
        {
            _itemsDal.Delete(GetById(id));
        }

        public List<Items> GetAll()
        {
            return _itemsDal.GetAll();
        }

        public Items GetById(int id)
        {
            return _itemsDal.Get(i => i.Id == id);
        }

        public Items GetByName(string name)
        {
            return _itemsDal.Get(i => i.Name == name);
        }

        public void Update(Items item)
        {
            _itemsDal.Update(item);
        }
    }
}
