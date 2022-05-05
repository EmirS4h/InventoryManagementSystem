using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        ItemsManager itemsManager;

        public ItemsController()
        {
            itemsManager = new ItemsManager(new EfItemsDal());
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public Items[] Get()
        {
            return itemsManager.GetAll().ToArray();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Items Get(int id)
        {
            return itemsManager.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
