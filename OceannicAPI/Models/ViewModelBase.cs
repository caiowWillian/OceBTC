using System;
using System.ComponentModel.DataAnnotations;

namespace OceannicAPI.Models
{
    public class ViewModelBase
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public DateTime InputDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? UpdateDate { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
