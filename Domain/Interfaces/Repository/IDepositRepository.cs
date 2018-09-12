using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IDepositRepository : IRepositoryBase<Deposit>
    {
        IList<Deposit> GetDepositByUserId(int userId);
        Task<IList<Deposit>> GetDepositByUserIdAsync(int userId);

        IList<Deposit> GetDepositByUserIdAndCoinId(int userId, int coinId);
        Task<IList<Deposit>> GetDepositByUserIdAndCoinIdAsync(int userId, int coinId);
    }
}
