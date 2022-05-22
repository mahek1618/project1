using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CricketWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CricketWebApp.Controllers
{
    [Route("ap[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly CricketContext _cricketContext;
        public MatchesController(CricketContext cricketContext)
        {
            _cricketContext = cricketContext;
        }
        // GET: api/Matches
        [HttpGet]
        [Route("Get3")]
        public IActionResult Get()
        {
            var getMatches = _cricketContext.Matches.ToList();
            return Ok(getMatches);
        }

        // GET: api/Matches/5
        [HttpGet("{id}", Name = "Get4")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Matches
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Matches/5
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
