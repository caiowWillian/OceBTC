using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class WalletService : ServiceBase<Wallet>, IWalletService
    {
        private IWalletRepository _repositoryWallet;

        public WalletService(IWalletRepository repositoryWallet)
            : base(repositoryWallet)
        {
            _repositoryWallet = repositoryWallet;
        }

        public Wallet GetWalletByGuid(string guid)
        {
            return _repositoryWallet.GetWalletByGuid(guid);
        }

        public async Task<Wallet> GetWalletByGuidAsync(string guid)
        {
            return await _repositoryWallet.GetWalletByGuidAsync(guid);
        }

        public IList<Wallet> GetWalletsByCurrencyId(int id)
        {
            return _repositoryWallet.GetWalletsByCurrencyId(id);
        }

        public async Task<IList<Wallet>> GetWalletsByCurrencyIdAsync(int id)
        {
            return await _repositoryWallet.GetWalletsByCurrencyIdAsync(id);
        }
    }
}
