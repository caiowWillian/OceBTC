using Application.Interface;
using Domain.Interfaces.Service;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class CurrencyAppService : AppServiceBase<Currency>, ICurrencyAppService
    {
        private readonly ICurrencyService _serviceCurrency;
        private readonly IDepositService _serviceDeposit;
        private readonly ITransferService _serviceTransfer;
        private readonly ITransactionService _serviceTransaction;

        public CurrencyAppService(
            ICurrencyService serviceCurrency
            ,IDepositService serviceDeposit
            ,ITransferService serviceTransfer
            ,ITransactionService serviceTransaction)
            : base(serviceCurrency)
        {
            _serviceCurrency = serviceCurrency;
            _serviceDeposit = serviceDeposit;
            _serviceTransfer = serviceTransfer;
            _serviceTransaction = serviceTransaction;
        }

        public double GetTotal(int userId, int coinId)
        {
            return GetTotalAsync(userId, coinId).Result;
        }

        public async Task<double> GetTotalAsync(int userId, int coinId)
        {
            var deposits = await _serviceDeposit.GetDepositByUserIdAndCoinIdAsync(userId, coinId);
            var transfer = await _serviceTransfer.GetTransferByUserIdAsync(userId, coinId);
            //var transactionBuy = await _serviceTransaction.GetTransactionByUserIdCoinIdTypeIdAsync(userId, coinId, 1);
            //var transactionSell = await _serviceTransaction.GetTransactionByUserIdCoinIdTypeIdAsync(userId, coinId, 2);


            double sumDeposits = 0;
            double sumTransfer = 0;
            double sumTransactionBuy = 0;

            foreach(var item in deposits)
            {
                sumDeposits += item.Value;
            }

            foreach(var item in transfer)
            {
                sumTransfer += item.Value;
            }



            //foreach(var item in transactionBuy)
            //{
            //    sumTransactionBuy += item.
            //}



            return sumDeposits - sumTransfer;
        }
    }
}
