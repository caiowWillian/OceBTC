using System.Collections.Generic;
using Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace OceannicAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IUserAppService _appUser;

        public ValuesController(IUserAppService appUser)
        {
            _appUser = appUser;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
