using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;

namespace Domain.Services
{
    public class TransferService : ServiceBase<Transfer>, ITransferService
    {
        private readonly ITransferRepository _repositoryTransfer;

        public TransferService(ITransferRepository repositoryTransfer)
            : base(repositoryTransfer)
        {
            _repositoryTransfer = repositoryTransfer;
        }

        public IList<Transfer> GetTransferByUserId(int userId, int coinId)
        {
            return GetTransferByUserId(userId, coinId);
        }

        public async Task<IList<Transfer>> GetTransferByUserIdAsync(int userId, int coinId)
        {
            return await _repositoryTransfer.GetTransferByUserIdAsync(userId, coinId);
        }
    }
}
