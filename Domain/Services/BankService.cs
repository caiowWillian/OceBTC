using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Models;

namespace Domain.Services
{
    public class BankService : ServiceBase<Bank>, IBankService
    {
        private readonly IBankRepository _repositoryBank;

        public BankService(IBankRepository repositoryBank)
            : base(repositoryBank)
        {
            _repositoryBank = repositoryBank;
        }
    }
}