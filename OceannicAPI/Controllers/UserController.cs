using Application.Interface;
using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using OceannicAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OceannicAPI.Controllers
{

    //[OceannicBasicAuthenticationFilter]
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private IUserAppService _appUser;
        private readonly IMapper _mapper;
        public UserController(IUserAppService appUser
                              ,IMapper maper)
        {
            _appUser = appUser;
            _mapper = maper;
        }

        // GET: api/User
        [HttpGet]
        public async Task<IActionResult> Get()
        {    
            return Ok(_mapper.Map<IList<User>,IList<UserViewModel>>(await _appUser.GetAllAsync()));
        }

        // GET: api/User/5
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            User user = await _appUser.GetByIdAsync(id);

            if (user == null)
                return NotFound();

            return Ok(Mapper.Map<User, UserViewModel>(user));
        }
        
        // POST: api/User
        [HttpPost]
        //[RequestSizeLimit(100_000_000_000_000_000)]
        public async Task<IActionResult> Post([FromBody]UserViewModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await _appUser.InsertAsync(_mapper.Map<UserViewModel, User>(value));
            }
            catch (System.Exception e)
            {

                throw;
            }
            return Ok();
        }
        
        // PUT: api/User/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UserViewModel value)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            await _appUser.UpdateAsync(Mapper.Map<UserViewModel, User>(value));

            return Ok();
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
