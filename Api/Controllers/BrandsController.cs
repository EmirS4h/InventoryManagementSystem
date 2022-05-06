using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        BrandsManager brandsManager;

        public BrandsController()
        {
            brandsManager = new BrandsManager(new EfBrandsDal());
        }

        // GET: api/<BrandsController>
        [HttpGet]
        public Brands[] Get()
        {
            return brandsManager.GetAll().ToArray();
        }

        // GET api/<BrandsController>/5
        [HttpGet("{id}")]
        public Brands Get(int id)
        {
            return brandsManager.GetById(id);
        }

        // POST api/<BrandsController>
        [HttpPost]
        public IActionResult Post([FromBody] Brands newBrand)
        {
            Brands brand = new Brands()
            {
                Name = newBrand.Name,
            };
            bool brandAdded = brandsManager.Add(brand);
            if(brandAdded) return Ok(brand);
            return BadRequest();
        }

        // PUT api/<BrandsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Brands brand)
        {
            brandsManager.Update(brand);
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            brandsManager.Delete(id);
        }
    }
}
