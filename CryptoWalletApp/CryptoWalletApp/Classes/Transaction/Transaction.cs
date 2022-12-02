using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Transaction
{
    public abstract class Transaction
    {
        public Guid Id { get; }
        public Guid AdressOfAsset { get; }  //ovo možda bude tribalo odvojeno za Fungible i NonFungible
        public DateTime DateOfTransaction { get; }
        public Guid AdressOfDonor { get; }
        public Guid AdressOfReceiver { get; }
        public bool WasRevoked { get; set; }
    }
}
