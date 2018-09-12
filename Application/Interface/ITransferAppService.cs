using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ITransferAppService : IAppServiceBase<Transfer>
    {
        IList<Transfer> GetTransferByUserId(int userId, int coinId);
        Task<IList<Transfer>> GetTransferByUserIdAsync(int userId, int coinId);
    }
}
