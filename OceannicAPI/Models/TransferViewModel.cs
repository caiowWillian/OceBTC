using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OceannicAPI.Models
{
    public class TransferViewModel : EntitieBaseViewModel, IValidatableObject
    {
        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public virtual UserViewModel User { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Valor é obrigatorio")]
        [DisplayName("Valor")]
        public double Value { get; set; }

        [DisplayName("Banco")]
        public int? UserBanksId { get; set; }

        [DisplayName("Agencia")]
        public string Agency { get; set; }

        [DisplayName("Conta")]
        public string Account { get; set; }

        public virtual UserBanksViewModel UserBanks { get; set; }

        public virtual CurrencyViewModel Currency { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Escolha uma Moeda")]
        [DisplayName("Moeda")]
        public int? CurrencyId { get; set; }

        [DisplayName("Carteira para realizar a transferencia")]
        public string UserWallet { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(CurrencyId == 1)
            {
                if (UserBanksId == null)
                    yield return new ValidationResult("Escolha um banco para deposito", new string[] { "UserBanksId" });

                if (string.IsNullOrEmpty(Agency) || string.IsNullOrWhiteSpace(Agency))
                    yield return new ValidationResult("Digite a agencia para deposito", new string[] { "Agency" });

                if (string.IsNullOrWhiteSpace(Account) || string.IsNullOrWhiteSpace(Account))
                    yield return new ValidationResult("Digite sua conta para deposito", new string[] { "Account" });
            }
            else
            {
                if (string.IsNullOrEmpty(UserWallet) || string.IsNullOrWhiteSpace(UserWallet))
                    yield return new ValidationResult("Digite a carteira para a transferencia", new string[] { "UserWallet" });
            }
        }
    }
}