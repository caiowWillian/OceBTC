using Domain.Interfaces.Repository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class WalletRepository : RepositoryBase<Wallet>, IWalletRepository
    {
        public Wallet GetWalletByGuid(string guid)
        {
            return GetWalletByGuidAsync(guid).Result;
        }

        public async Task<Wallet> GetWalletByGuidAsync(string guid)
        {
            return await _ctx.Wallet.Where(x => x.Guid == guid).FirstOrDefaultAsync();
        }

        public IList<Wallet> GetWalletsByCurrencyId(int id)
        {
            return _ctx.Wallet.Where(x => x.CurrencyId == id).ToList();
        }

        public async Task<IList<Wallet>> GetWalletsByCurrencyIdAsync(int id)
        {
            return await _ctx.Wallet.Where(x => x.CurrencyId == id).ToListAsync();
        }
    }
}
