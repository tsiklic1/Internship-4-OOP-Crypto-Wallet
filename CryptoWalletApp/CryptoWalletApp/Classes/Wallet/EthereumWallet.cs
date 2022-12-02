using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Wallet
{
    public class EthereumWallet : AbleToInteractWithNonFungibleAssetWallet
    {
        public EthereumWallet() : base() { }


        public override bool AddBalanceOfFungibleAsset(Guid fungibleAsset, decimal amountOfFungibleAssetToBeAdded)
        {
            return base.AddBalanceOfFungibleAsset(fungibleAsset, amountOfFungibleAssetToBeAdded);
        }
        
        public override bool AddSupportedNonFungibleAsset(Guid newNonFungibleAsset)
        {
            return base.AddSupportedNonFungibleAsset(newNonFungibleAsset);
        }
    }
}
