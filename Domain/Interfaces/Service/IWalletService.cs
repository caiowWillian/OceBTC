using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IWalletService : IServiceBase<Wallet>
    {
        IList<Wallet> GetWalletsByCurrencyId(int id);
        Task<IList<Wallet>> GetWalletsByCurrencyIdAsync(int id);

        Wallet GetWalletByGuid(string guid);
        Task<Wallet> GetWalletByGuidAsync(string guid);
    }
}
