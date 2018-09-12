using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserByLogin(string email, string pw)
        {
            return _userRepository.GetUserByLogin(email, pw);
        }

        public async Task<User> GetUserByLoginAsync(string email, string pw)
        {
            return await _userRepository.GetUserByLoginAsync(email, pw);
        }

        public bool Login(string email, string pw)
        {
            return _userRepository.Login(email, pw);
        }

        public async Task<bool> LoginAsync(string email, string pw)
        {
            return await _userRepository.LoginAsync(email, pw);
        }
    }
}