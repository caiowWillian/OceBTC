using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ITransactionService : IServiceBase<Transaction>
    {
        IList<Transaction> GetTransactionByUserIdCoinIdTypeId(int userId, int coinId, int typeId);
        Task<IList<Transaction>> GetTransactionByUserIdCoinIdTypeIdAsync(int userId, int coinId, int typeId);
    }
}
