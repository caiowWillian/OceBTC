using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OceannicAPI.Models
{
    public class UserViewModel : ViewModelBase, IValidatableObject
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }
   
        [DisplayName("CEP")]
        [Required(ErrorMessage = "CEP é obrigatório", AllowEmptyStrings = false)]
        public string Cep { get; set; }

        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail é obrigátório", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Senha")]
        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Pw { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirmar senha")]
        [Required(ErrorMessage = "Por favor, confirme sua senha")]
        public string ConfPw { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "Cpf é obrigatório", AllowEmptyStrings = false)]
        public string Cpf { get; set; }

        [ScaffoldColumn(false)]
        public bool Admin { get; set; } = false;

        public int? ImgUserId { get; set; }
        public virtual ImgUserViewModel ImgUser { get; set; }

        

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Pw != ConfPw)
                yield return new ValidationResult("As senhas não confere", new string[] { "Pw", "ConfPw" });

            if (!Util.Cpf.IsCpf(Cpf))
                 yield return new ValidationResult("Cpf Invalido", new string[] { "Cpf" });
        }
    }
}
