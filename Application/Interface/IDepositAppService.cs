using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IDepositAppService : IAppServiceBase<Deposit>
    {
        IList<Deposit> GetDepositByUserId(int userId);
        Task<IList<Deposit>> GetDepositByUserIdAsync(int userId);
    }
}
