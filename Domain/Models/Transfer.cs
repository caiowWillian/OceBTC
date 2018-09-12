namespace Domain.Models
{
    public class Transfer : EntitieBase
    {
        public int UserId { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public virtual User User { get; set; }

        public double Value { get; set; }

        public int? UserBanksId { get; set; }
    
        public string Agency { get; set; }

        public string Account { get; set; }

        //[System.Runtime.Serialization.IgnoreDataMember]
        public virtual UserBanks UserBanks { get; set; }

        public virtual Currency Currency { get; set; }
        public int? CurrencyId { get; set; }

        public string UserWallet { get; set; }
    }
}
