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
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public IList<Transaction> GetTransactionByUserIdCoinIdTypeId(int userId, int coinId, int typeId)
        {
            return GetTransactionByUserIdCoinIdTypeIdAsync(userId, coinId, typeId).Result;
        }

        public async Task<IList<Transaction>> GetTransactionByUserIdCoinIdTypeIdAsync(int userId, int coinId, int typeId)
        {
            return await _ctx.Transaction
                .Where(x => x.Ativo && x.UserId == userId && x.CurrencyId == coinId && x.TransactionTypeId == typeId)
                .ToListAsync();
        }
    }
}
