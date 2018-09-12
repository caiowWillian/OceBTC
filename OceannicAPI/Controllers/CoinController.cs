using System.Threading.Tasks;
using Application.Interface;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;

namespace OceannicAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Coin")]
    public class CoinController : ODataController
    {
        private readonly ICurrencyAppService _appCurrency;

        public CoinController(ICurrencyAppService appCurrency)
        {
            _appCurrency = appCurrency;
            
        }

        // GET: api/Currecy
        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appCurrency.GetAllAsync());
        }

        //[EnableQuery]
        [HttpGet]
        [ODataRoute("TotalCurrency(userId={userId},currencyId={currencyId})")]
        public async Task<double> TotalCurrency([FromODataUri]int userId, int currencyId)
        {
            return await _appCurrency.GetTotalAsync(userId,currencyId);
        }

        // GET: api/Currecy/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Currecy
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Currecy/5
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
