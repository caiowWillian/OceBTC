using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;

namespace Application.Implementation
{
    public class TransferAppService : AppServiceBase<Transfer>, ITransferAppService
    {
        private readonly ITransferService _serviceTransfer;

        public TransferAppService(ITransferService serviceTransfer)
            : base(serviceTransfer)
        {
            _serviceTransfer = serviceTransfer;
        }

        public IList<Transfer> GetTransferByUserId(int userId, int coinId)
        {
            return _serviceTransfer.GetTransferByUserId(userId, coinId);
        }

        public async Task<IList<Transfer>> GetTransferByUserIdAsync(int userId, int coinId)
        {
            return await _serviceTransfer.GetTransferByUserIdAsync(userId, coinId);
        }
    }
}