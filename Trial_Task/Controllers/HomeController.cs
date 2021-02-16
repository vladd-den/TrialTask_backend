using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Trial_Task.Models;

namespace Trial_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private UserContext _context;
        public HomeController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Users")]
        public object GetUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        [HttpPut]
        [Route("Users/Update")]
        public object Update(User user)
        {
            if(user != null)
            {
                try
                {
                    _context.Users.Update(user);
                    _context.SaveChanges();
                    return Ok(user);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return BadRequest();
            }
            
            
        }
    }
}