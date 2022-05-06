using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoriesService
    {
        Categories[] GetAll();
        Categories GetById(int id);
        Categories GetByName(string name);
        bool Add(Categories category);
        void Update(Categories category);
        void Delete(Categories category);
    }
}
