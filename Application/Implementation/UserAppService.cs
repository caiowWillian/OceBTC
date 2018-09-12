using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _serviceUser;

        public UserAppService(IUserService serviceUser)
            : base(serviceUser)
        {
            _serviceUser = serviceUser;
        }

        public User GetUserByLogin(string email, string pw)
        {
            return _serviceUser.GetUserByLogin(email, pw);
        }

        public async Task<User> GetUserByLoginAsync(string email, string pw)
        {
            return await _serviceUser.GetUserByLoginAsync(email, pw);
        }

        public bool Login(string email, string pw)
        {
            return _serviceUser.Login(email, pw);
        }

        public async Task<bool> LoginAsync(string email, string pw)
        {
            return await _serviceUser.LoginAsync(email, pw);
        }
    }
}