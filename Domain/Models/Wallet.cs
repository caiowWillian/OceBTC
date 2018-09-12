namespace Domain.Models
{
    public class Wallet : EntitieBase
    {
        public string Guid { get; set; }

        public virtual Currency Currency { get; set; }
        public int CurrencyId { get; set; }
    }
}
