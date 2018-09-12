using Domain.Interfaces.Repository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class DepositRepository : RepositoryBase<Deposit>, IDepositRepository
    {
        public IList<Deposit> GetDepositByUserId(int userId)
        {
            return GetDepositByUserIdAsync(userId).Result;
        }

        public IList<Deposit> GetDepositByUserIdAndCoinId(int userId, int coinId)
        {
            return GetDepositByUserIdAndCoinIdAsync(userId, coinId).Result;
        }

        public async Task<IList<Deposit>> GetDepositByUserIdAndCoinIdAsync(int userId, int coinId)
        {
            return await _ctx.Deposit.Where(x => x.UserId == userId && x.CurrencyId == coinId && x.Ativo).ToListAsync();
        }

        public async Task<IList<Deposit>> GetDepositByUserIdAsync(int userId)
        {
            return await _ctx.Deposit.Where(x => x.UserId == userId).ToListAsync();
        }
    }
}
