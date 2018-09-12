using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OceannicAPI.Models;

namespace OceannicAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Wallet")]
    public class WalletController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWalletAppService _appWalletService;

        public WalletController(
            IWalletAppService appWalletService
            ,IMapper mapper)
        {
            _mapper = mapper;
            _appWalletService = appWalletService;
        }

        // GET: api/Wallet
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Wallet/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var itens = (await _appWalletService.GetWalletsByCurrencyIdAsync(id));

            Random r = new Random();

            int n = r.Next(itens.Count());

            return Ok((itens[n].Guid));
        }

        // POST: api/Wallet
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Wallet/5
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
