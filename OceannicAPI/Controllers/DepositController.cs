using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interface;
using AutoMapper;
using Domain.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using OceannicAPI.Models;

namespace OceannicAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Deposit")]
    public class DepositController : ODataController
    {
        private readonly IMapper _mapper;
        private readonly IDepositAppService _appDepositService;
        private readonly IWalletAppService _appWalletService;
        private readonly IBankAppService _appBankAppService;

        public DepositController(
            IMapper mapper
            ,IDepositAppService appDepositService
            ,IWalletAppService appWalletService)
        {
            _mapper = mapper;
            _appDepositService = appDepositService;
            _appWalletService = appWalletService;
        }
        
        // GET: api/Deposit
        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {

            return Ok(await _appDepositService.GetAllAsync());
        }

        // GET: api/Deposit/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }
        
        // POST: api/Deposit
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]DepositViewModel model)
        {
            Deposit deposit = _mapper.Map<DepositViewModel, Deposit>(model);
            deposit.Ativo = false;
            if (model.UserWallet != null)
            {
                Wallet wallet = await _appWalletService.GetWalletByGuidAsync(model.Guid);
                deposit.WalletId = wallet.Id;
                deposit.BankId = null;
            }
            else
            {
                deposit.BankId = model.BankId;
            }

            try
            {
                await _appDepositService.InsertAsync(deposit);
            }
            catch (Exception e)
            {

                throw;
            }


            return Ok();
        }
        
        // PUT: api/Deposit/5
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
