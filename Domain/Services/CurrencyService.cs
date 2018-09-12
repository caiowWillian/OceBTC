using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;

namespace Domain.Services
{
    public class CurrencyService : ServiceBase<Currency>, ICurrencyService
    {
        private ICurrencyRepository _repositoryCurrency;
        
        public CurrencyService(ICurrencyRepository repositoryCurrency)
            : base(repositoryCurrency)
        {
            _repositoryCurrency = repositoryCurrency;
        }
    }
}