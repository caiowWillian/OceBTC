using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CurrencyRepository : RepositoryBase<Currency>, ICurrencyRepository
    {
        public double GetTotal(int userId, int coinId)
        {
            IList<Deposit> deposits;

            using(var _ctxDeposit = new DepositRepository())
            {
                deposits = _ctxDeposit.GetDepositByUserId(userId)
                    .Where(x => x.Ativo).ToList();
            }

            throw new NotImplementedException();
        }

        public Task<double> GetTotalAsync(int userId, int coinId)
        {
            throw new NotImplementedException();
        }
    }
}
