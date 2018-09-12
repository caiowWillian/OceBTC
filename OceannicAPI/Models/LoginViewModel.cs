using System.ComponentModel.DataAnnotations;

namespace OceannicAPI.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite seu Email")]
        public string Usuario { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Digite sua Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
