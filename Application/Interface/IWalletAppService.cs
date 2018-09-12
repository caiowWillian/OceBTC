using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IWalletAppService : IAppServiceBase<Wallet>
    {
        IList<Wallet> GetWalletsByCurrencyId(int id);
        Task<IList<Wallet>> GetWalletsByCurrencyIdAsync(int id);

        Wallet GetWalletByGuid(string guid);
        Task<Wallet> GetWalletByGuidAsync(string guid);
    }
}
