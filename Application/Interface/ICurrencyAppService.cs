using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ICurrencyAppService : IAppServiceBase<Currency>
    {
        double GetTotal(int userId, int coinId);
        Task<double> GetTotalAsync(int userId, int coinId);
    }
}
