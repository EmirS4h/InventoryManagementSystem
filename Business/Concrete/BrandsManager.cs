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
    public class BrandsManager : IBrandsService
    {
        IBrandsDal _brandsDal;

        public BrandsManager(IBrandsDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public bool Add(Brands item)
        {
            Brands brandExist = GetByName(item.Name);
            if (brandExist != null) return false;
            _brandsDal.Add(item);
            return true;
        }

        public void Delete(int id)
        {
            _brandsDal.Delete(GetById(id));
        }

        public List<Brands> GetAll()
        {
            return _brandsDal.GetAll();
        }

        public Brands GetById(int id)
        {
            return _brandsDal.Get(b => b.Id == id);
        }

        public Brands GetByName(string name)
        {
            return _brandsDal.Get(b => b.Name == name);
        }

        public void Update(Brands item)
        {
            _brandsDal.Update(item);
        }
    }
}
