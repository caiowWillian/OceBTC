using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class User : EntitieBase
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Cep { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Pw { get; set; }

        [Required]
        public string Cpf { get; set; }

        public bool Admin { get; set; } = false;

        public int? ImgUserId { get; set; }
        public virtual ImgUser ImgUser { get; set; }

    }
}
