using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerMorten;
using BeerRestOpg4.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerRestOpg4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeerManager _manager = new BeerManager();
        // GET: api/<BeersController>
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return _manager.Getall();
        }

        // GET api/<BeersController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return _manager.getById(id);
        }

        // POST api/<BeersController>
        [HttpPost]
        public void Post([FromBody] Beer value)
        {
            _manager.Add(value);
        }

        // PUT api/<BeersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Beer value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<BeersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _manager.Delete(id);
        }
    }
}
