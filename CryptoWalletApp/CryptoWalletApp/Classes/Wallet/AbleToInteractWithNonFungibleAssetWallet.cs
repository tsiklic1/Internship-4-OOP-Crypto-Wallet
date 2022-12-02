using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Wallet
{
    public abstract class AbleToInteractWithNonFungibleAssetWallet : Wallet
    {
        public List<Guid> AdressesOfOwnedNonFungibleAssets { get; set; }
        public List<Guid> AdressesOfSupportedNonFungibleAssets { get; set; }  //ovo mi možda i ne triba nego samo uvalit sa Fungible
        //isto za sve eth/sol wallete

        public AbleToInteractWithNonFungibleAssetWallet() : base() { }

    }
}
