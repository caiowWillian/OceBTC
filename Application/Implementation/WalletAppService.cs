using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class WalletAppService : AppServiceBase<Wallet>, IWalletAppService
    {
        private IWalletService _serviceWallet;

        public WalletAppService(IWalletService serviceWallet)
            : base(serviceWallet)
        {
            _serviceWallet = serviceWallet;
        }

        public Wallet GetWalletByGuid(string guid)
        {
            return _serviceWallet.GetWalletByGuid(guid);
        }

        public async Task<Wallet> GetWalletByGuidAsync(string guid)
        {
            return await _serviceWallet.GetWalletByGuidAsync(guid);
        }

        public IList<Wallet> GetWalletsByCurrencyId(int id)
        {
            return _serviceWallet.GetWalletsByCurrencyId(id);
        }

        public async Task<IList<Wallet>> GetWalletsByCurrencyIdAsync(int id)
        {
            return await _serviceWallet.GetWalletsByCurrencyIdAsync(id);
        }
    }
}
