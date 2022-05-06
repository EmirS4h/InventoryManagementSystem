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
    public class CategoriesManager : ICategoriesService
    {
        ICategoriesDal _categoriesDal;

        public CategoriesManager(ICategoriesDal categoriesDal)
        {
            _categoriesDal = categoriesDal;
        }

        public bool Add(Categories category)
        {
            Categories categoryExist = GetByName(category.Name);
            if (categoryExist != null) return false; // eger kategori varsa ekleme
            _categoriesDal.Add(category);
            return true;
        }

        public void Delete(Categories category)
        {
            _categoriesDal.Delete(category);
        }

        public Categories[] GetAll()
        {
            return _categoriesDal.GetAll().ToArray();
        }

        public Categories GetById(int id)
        {
            return _categoriesDal.Get(c => c.Id == id);
        }

        public Categories GetByName(string name)
        {
            return _categoriesDal.Get(c => c.Name == name);
        }

        public void Update(Categories category)
        {
            _categoriesDal.Update(category);
        }
    }
}
