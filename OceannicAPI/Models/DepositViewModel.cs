namespace OceannicAPI.Models
{
    public class DepositViewModel : EntitieBaseViewModel
    {
        public int UserId { get; set; }
        public virtual UserViewModel User { get; set; }

        public double Value { get; set; }

        public int? WalletId { get; set; }
        public virtual WalletViewModel Wallet { get; set; }

        public int? BankId { get; set; }
        public virtual BankViewModel Bank { get; set; }

        public virtual CurrencyViewModel Currency { get; set; }
        public int CurrencyId { get; set; }

        public string UserWallet { get; set; }

        public string Guid { get; set; }
    }
}
