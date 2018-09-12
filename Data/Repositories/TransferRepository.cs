using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Repository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class TransferRepository : RepositoryBase<Transfer>, ITransferRepository
    {
        public IList<Transfer> GetTransferByUserId(int userId, int coinId)
        {
            return GetTransferByUserIdAsync(userId, coinId).Result;
        }

        public async Task<IList<Transfer>> GetTransferByUserIdAsync(int userId, int coinId)
        {
            return await _ctx.Transfer.Where(x => x.UserId == userId && x.CurrencyId == coinId).ToListAsync();
        }
    }
}
