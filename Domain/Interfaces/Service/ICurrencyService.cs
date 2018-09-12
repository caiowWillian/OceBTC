using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ICurrencyService : IServiceBase<Currency>
    {
        //double GetTotal(int userId, int coinId);
        //Task<double> GetTotalAsync(int userId, int coinId);
    }
}
