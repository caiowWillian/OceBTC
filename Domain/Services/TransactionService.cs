using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class TransactionService : ServiceBase<Transaction>, ITransactionService
    {
        private readonly ITransactionRepository _repositoryTransaction;

        public TransactionService(ITransactionRepository repositoryTransaction)
            : base(repositoryTransaction)
        {
            _repositoryTransaction = repositoryTransaction;
        }

        public IList<Transaction> GetTransactionByUserIdCoinIdTypeId(int userId, int coinId, int typeId)
        {
            return _repositoryTransaction.GetTransactionByUserIdCoinIdTypeId(userId, coinId, typeId);
        }

        public async Task<IList<Transaction>> GetTransactionByUserIdCoinIdTypeIdAsync(int userId, int coinId, int typeId)
        {
            return await _repositoryTransaction.GetTransactionByUserIdCoinIdTypeIdAsync(userId, coinId, typeId);
        }
    }
}
