using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Oceannic.Models
{
    public class AllDepositViewModel
    {


        public int Moedas { get; set; }
        public double ValorDeposito { get; set; }
        public int? SelectBancos { get; set; }
        public string AddressWallet { get; set; }
        public string WalletGuid { get; set; }
    }
}
