using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class TransactionAlter
    {
        public int Id { get; set; }
        public virtual Currency Currency { get; set; }
        public int CurrencyId { get; set; }

        public double Value { get; set; }

        public bool Make { get; set; } = false;
    }
}
