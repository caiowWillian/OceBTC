using Domain.Interfaces.Repository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UsersRepository : RepositoryBase<User>, IUserRepository
    {
        public User GetUserByLogin(string email, string pw)
        {
            return GetUserByLoginAsync(email, pw).Result;
        }

        public async Task<User> GetUserByLoginAsync(string email, string pw)
        {
            return await _ctx.User.FirstOrDefaultAsync(x => x.Email == email && x.Pw == pw);
        }

        public bool Login(string email, string pw)
        {
            return LoginAsync(email, pw).Result;
        }

        public async Task<bool> LoginAsync(string email, string pw)
        {
            User user = await _ctx.User
                .Where(x => x.Email == email && x.Pw == pw)
                .FirstOrDefaultAsync();

            if (user == null)
                return false;

            return true;
        }
    }
}
