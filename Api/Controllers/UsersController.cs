using Business.Concrete;
using Core.PasswordControls;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;

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

        [HttpGet("admins")]
        [Authorize]
        public IActionResult AdminArea()
        {
            var currentUser = GetCurrentUser();
            return Ok($"Hello admin {currentUser.Name} your role : {currentUser.Role}");
        }

        [HttpGet("kekolar")]
        [Authorize(Roles = "Standart")]
        public IActionResult StdandartKeko()
        {
            var currentUser = GetCurrentUser();
            return Ok($"Hello kekko {currentUser.Name} your role : {currentUser.Role}");
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
                Role = value.Role,
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

        [HttpGet("public")]
        public IActionResult Public()
        {
            return Ok("Hg cnm");
        }

        public Users GetCurrentUser()
        {
            if (HttpContext.User.Identity is ClaimsIdentity identity)
            {
                var userClaims = identity.Claims;
                Users user = new()
                {
                    Name = userClaims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier)?.Value,
                    Surname = userClaims.FirstOrDefault(u => u.Type == ClaimTypes.Surname)?.Value,
                    Email = userClaims.FirstOrDefault(u => u.Type == ClaimTypes.Email)?.Value,
                    Role = userClaims.FirstOrDefault(u => u.Type == ClaimTypes.Role)?.Value,
                };
                return user;
            }
            return null;
        }
    }
}
