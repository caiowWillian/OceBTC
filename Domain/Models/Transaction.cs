using System.Collections.Generic;

namespace Domain.Models
{
    public class Transaction : EntitieBase
    {
        public virtual User User { get; set; }
        public int UserId { get; set; }

        public virtual TransactionType TransactionType { get; set; }
        public int TransactionTypeId { get; set; }

        public virtual Currency Currency { get; set; }
        public int CurrencyId { get; set; }

        public bool WithVariation { get; set; }

        public double VariationUp { get; set; }
        public double VariationDown { get; set; }

        public virtual Transaction TransactionRelation { get; set; }
        public int? TransactionRelationId { get; set; }

        public double Value { get; set; }

        public virtual IList<TransactionAlter> TransactionAlter { get; set; }

    }
}