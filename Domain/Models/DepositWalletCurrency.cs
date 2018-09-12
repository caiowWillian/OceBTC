using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class DepositWalletCurrency
    {
        public virtual Wallet Wallet { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual Deposit Deposit { get; set; }
    }
}
