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
    public class PlayerController : ControllerBase
    {
        // GET: api/Player
        private readonly CricketContext _cricketContext;
        public PlayerController(CricketContext cricketContext)
        {
            _cricketContext = cricketContext;
        }
        [HttpGet]
        [Route("Get1")]
        public IActionResult Get()
        {
            var getPlayer = _cricketContext.Player.ToList();
            return Ok(getPlayer);
        }
        // GET: api/Player/5
        [HttpGet("{id}", Name = "Get2")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Player
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
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
