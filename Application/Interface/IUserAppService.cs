using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUserAppService : IAppServiceBase<User>
    {
        bool Login(string email, string pw);
        Task<bool> LoginAsync(string email, string pw);

        User GetUserByLogin(string email, string pw);
        Task<User> GetUserByLoginAsync(string email, string pw);
    }
}
