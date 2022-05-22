using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CricketWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CricketWebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        // GET: api/Stadium
        private readonly CricketContext _cricketContext;
        public StadiumController(CricketContext cricketContext)
        {
            _cricketContext = cricketContext;
        }
        [HttpGet]
        [Route("Get2")]
        public IActionResult Get()
        {
            var getStadium = _cricketContext.State.ToList();
            return Ok(getStadium);
        }
        // GET: api/Stadium/5
        [HttpGet("{id}", Name = "Get3")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stadium
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stadium/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
