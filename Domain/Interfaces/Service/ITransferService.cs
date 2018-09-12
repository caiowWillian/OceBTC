using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ITransferService : IServiceBase<Transfer>
    {
        IList<Transfer> GetTransferByUserId(int userId, int coinId);
        Task<IList<Transfer>> GetTransferByUserIdAsync(int userId, int coinId);
    }
}
