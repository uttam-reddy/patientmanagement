using Microsoft.AspNetCore.Mvc;
using PatientManagement.Application.Interfaces;
using PatientManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PatientManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private  IUsersService _iuserservice { get; }

        public UsersController(IUsersService iuserservice)
        {
            _iuserservice = iuserservice;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public Task<IEnumerable<User>> Get()
        {
            return _iuserservice.GetUsersListAsync();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public void Get(int id)
        {
            
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
