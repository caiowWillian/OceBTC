using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DepositService : ServiceBase<Deposit>, IDepositService
    {
        private IDepositRepository _repositoryDeposit;
        
        public DepositService(IDepositRepository repositoryDeposit)
            : base(repositoryDeposit)
        {
            _repositoryDeposit = repositoryDeposit;
        }

        public IList<Deposit> GetDepositByUserId(int userId)
        {
            return _repositoryDeposit.GetDepositByUserId(userId);
        }

        public IList<Deposit> GetDepositByUserIdAndCoinId(int userId, int coinId)
        {
            return _repositoryDeposit.GetDepositByUserIdAndCoinId(userId, coinId);
        }

        public async Task<IList<Deposit>> GetDepositByUserIdAndCoinIdAsync(int userId, int coinId)
        {
            return await _repositoryDeposit.GetDepositByUserIdAndCoinIdAsync(userId, coinId);
        }

        public async Task<IList<Deposit>> GetDepositByUserIdAsync(int userId)
        {
            return await _repositoryDeposit.GetDepositByUserIdAsync(userId);
        }
    }
}
