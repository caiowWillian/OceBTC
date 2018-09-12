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
    [Route("api/Transfer")]
    public class TransferController : ODataController
    {
        private readonly IMapper _mapper;
        private readonly ITransferAppService _appTransfer;

        public TransferController(
            IMapper mapper
            ,ITransferAppService appTransfer)
        {
            _mapper = mapper;
            _appTransfer = appTransfer;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            return Ok(await _appTransfer.GetAllAsync());
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TransferViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                model.Ativo = false;
                return Ok(await _appTransfer.InsertAsync(_mapper.Map<TransferViewModel, Transfer>(model)));
            }
            catch (System.Exception e)
            {
                return new StatusCodeResult(500);
            }
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
