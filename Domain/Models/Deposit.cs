using System;

namespace Domain.Models
{
    [Serializable]
    public class Deposit : EntitieBase
    {
        public int UserId { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public virtual User User { get; set; }

        public double Value { get; set; }
        
        public int? WalletId { get; set; }

        //[System.Runtime.Serialization.IgnoreDataMember]
        public virtual Wallet Wallet { get; set; }

        public int? BankId { get; set; }

        //[System.Runtime.Serialization.IgnoreDataMember]
        public virtual Bank Bank { get; set; }

        public virtual Currency Currency { get; set; }
        public int? CurrencyId { get; set; }

        public string UserWallet { get; set; }
    }
}