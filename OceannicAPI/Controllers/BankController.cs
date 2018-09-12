using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OceannicAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Bank")]
    public class BankController : ODataController
    {
        private readonly IBankAppService _appBank;

        public BankController(IBankAppService appBank)
        {
            _appBank = appBank;
        }

        // GET: api/Bank
        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appBank.GetAllAsync());
        }
        
        // POST: api/Bank
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Bank/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
