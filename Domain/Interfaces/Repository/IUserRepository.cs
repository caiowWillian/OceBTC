using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        bool Login(string email, string pw);
        Task<bool> LoginAsync(string email, string pw);

        User GetUserByLogin(string email, string pw);
        Task<User> GetUserByLoginAsync(string email, string pw);
    }
}
