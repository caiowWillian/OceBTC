using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface ITransferRepository : IRepositoryBase<Transfer>
    {
        IList<Transfer> GetTransferByUserId(int userId, int coinId);
        Task<IList<Transfer>> GetTransferByUserIdAsync(int userId, int coinId);
    }
}
