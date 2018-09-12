using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IWalletRepository : IRepositoryBase<Wallet>
    {
        IList<Wallet> GetWalletsByCurrencyId(int id);
        Task<IList<Wallet>> GetWalletsByCurrencyIdAsync(int id);

        Wallet GetWalletByGuid(string guid);
        Task<Wallet> GetWalletByGuidAsync(string guid);
    }
}
