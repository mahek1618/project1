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
    public class CountryController : ControllerBase
    {
        private readonly CricketContext _cricketContext;
        public CountryController(CricketContext cricketContext)
        {
            _cricketContext = cricketContext;
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            var getCountry = _cricketContext.Country.ToList();
            return Ok(getCountry);
        }
        // GET: api/Cricket/5
        [HttpGet("{id}", Name = "Get1")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cricket
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cricket/5
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
