using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        CategoriesManager categoriesManager;

        public CategoriesController()
        {
            categoriesManager = new CategoriesManager(new EfCategoriesDal());
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public Categories[] Get()
        {
            return categoriesManager.GetAll();
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public Categories Get(int id)
        {
            return categoriesManager.GetById(id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Post([FromBody] Categories category)
        {
            Categories categoryData = new Categories()
            {
                Name = category.Name,
            };
            bool categoryAdded = categoriesManager.Add(categoryData);
            if (categoryAdded)
            {
                return Ok(category);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Categories category)
        {
            categoriesManager.Update(category);
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            categoriesManager.Delete(Get(id));
        }
    }
}
