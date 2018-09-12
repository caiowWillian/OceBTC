using System;

namespace Domain.Models
{
    public class EntitieBase
    {
        public string Describe { get; set; }
        public int Id { get; set; }
        public DateTime InputDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
