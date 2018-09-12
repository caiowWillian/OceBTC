using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Implementation
{
    public class TransactionAppService : AppServiceBase<Transaction>, ITransactionAppService
    {
        private readonly ITransactionService _serviceTransaction;

        public TransactionAppService(ITransactionService serviceTransaction)
            : base(serviceTransaction)
        {
            _serviceTransaction = serviceTransaction;
        }
    }
}
