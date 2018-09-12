using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OceannicAPI.Models
{
    public class EntitieBaseViewModel
    {
        [DisplayName("Descrição")]
        public string Describe { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public DateTime InputDate { get; set; } = DateTime.Now;
        [ScaffoldColumn(false)]
        public DateTime? UpdateDate { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; } = true;
    }
}
