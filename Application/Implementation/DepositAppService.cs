using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class DepositAppService : AppServiceBase<Deposit>, IDepositAppService
    {
        private IDepositService _serviceDeposit;

        public DepositAppService(IDepositService serviceDeposit)
            : base(serviceDeposit)
        {
            _serviceDeposit = serviceDeposit;
        }

        public IList<Deposit> GetDepositByUserId(int userId)
        {
            return _serviceDeposit.GetDepositByUserId(userId);
        }

        public async Task<IList<Deposit>> GetDepositByUserIdAsync(int userId)
        {
            return await _serviceDeposit.GetDepositByUserIdAsync(userId);
        }
    }
}
