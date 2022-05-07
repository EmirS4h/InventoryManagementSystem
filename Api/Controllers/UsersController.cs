using Business.Concrete;
using Core.PasswordControls;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UsersManager usersManager;

        public UsersController()
        {
            usersManager = new UsersManager(new EfUsersDal());
        }
        // GET: api/<UsersController>
        [HttpGet]
        public Users[] Get()
        {
            return usersManager.GetAll().ToArray();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Users user = usersManager.GetById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] Users value)
        {
            Users newUser = new Users()
            {
                Name = value.Name,
                Surname = value.Surname,
                Email = value.Email,
                PhoneNumber = value.PhoneNumber,
                Password = SecurePassword.HashPassword(value.Password),
                LastLogin = DateTime.Now.ToString(),
                RegisteredAt = DateTime.Now.ToString(),
            };
            bool userAdded = usersManager.Add(newUser);
            if (userAdded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Users user)
        {
            usersManager.Update(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            usersManager.Delete(usersManager.GetById(id));
        }
    }
}
