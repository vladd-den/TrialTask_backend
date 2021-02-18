using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Trial_Task.Data;
using Trial_Task.Models;

namespace Trial_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IRepository<User> repository;
        public HomeController(IRepository<User> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        [Route("Users")]
        public async Task<List<User>> GetUsers()
        {
            return await repository.GetAll();
        }

        [HttpPut]
        [Route("Users/Update")]
        public async Task<Object> Update(User user)
        {
            if (user != null)
            {
                try
                {
                    await repository.Update(user);
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