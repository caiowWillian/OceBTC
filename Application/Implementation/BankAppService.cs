using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;

namespace Application.Implementation
{
    public class BankAppService : AppServiceBase<Bank>, IBankAppService
    {
        private readonly IBankService _serviceBank;

        public BankAppService(IBankService serviceBank)
            : base(serviceBank)
        {
            _serviceBank = serviceBank;
        }
    }
}