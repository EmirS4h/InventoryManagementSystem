using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandsService
    {
        List<Brands> GetAll();
        Brands GetById(int id);
        Brands GetByName(string name);
        void Delete(int id);
        bool Add(Brands item);
        void Update(Brands item);
    }
}
