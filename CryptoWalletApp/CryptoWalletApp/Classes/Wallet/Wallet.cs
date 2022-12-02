using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Wallet
{
    public abstract class Wallet
    {
        public Guid Adress { get; }
        public Dictionary<Guid, decimal> BalancesOfFungibleAsset { get; private set; } //mozda samo set
        public List<Guid> AdressesOfSupportedFungibleAssets { get; private set; }  //ovo je isto za sve wallete istog tipa (BTC, ETH, ...)
        public List<Guid> AdressesOfTransactions { get; private set; }

        public Wallet() 
        {
            Adress = Guid.NewGuid();
        }

    }
}
