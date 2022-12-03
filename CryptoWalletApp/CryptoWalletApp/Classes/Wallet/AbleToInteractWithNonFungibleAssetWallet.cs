using CryptoWalletApp.Classes.Asset;
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

        public AbleToInteractWithNonFungibleAssetWallet() : base() 
        {
            AdressesOfOwnedNonFungibleAssets= new List<Guid>();
            AdressesOfSupportedNonFungibleAssets = new List<Guid>();
        }

        public override bool AddSupportedFungibleAsset(Guid newFungibleAsset)
        {
            return base.AddSupportedFungibleAsset(newFungibleAsset);
        }
        public override bool AddBalanceOfFungibleAsset(Guid fungibleAsset, decimal amountOfFungibleAssetToBeAdded)
        {
            return base.AddBalanceOfFungibleAsset(fungibleAsset, amountOfFungibleAssetToBeAdded);
        }

        public virtual bool AddSupportedNonFungibleAsset(Guid newNonFungibleAsset)
        {
            if (AdressesOfSupportedNonFungibleAssets.Contains(newNonFungibleAsset))
            {
                return false;
            }
            AdressesOfSupportedNonFungibleAssets.Add(newNonFungibleAsset);
            return true;
        }

        public virtual bool AddNonFungibleAsset(Guid nonFungibleAsset)
        {
            if (AdressesOfOwnedNonFungibleAssets.Contains(nonFungibleAsset) || !AdressesOfSupportedNonFungibleAssets.Contains(nonFungibleAsset))
            {
                return false;
            }
            AdressesOfOwnedNonFungibleAssets.Add(nonFungibleAsset);
            return true;
        }

        public virtual bool DoesOwnNonFungibleAsset(Guid nonFungibleAsset)
        {
            if (AdressesOfOwnedNonFungibleAssets.Contains(nonFungibleAsset))
            {
                return true;
            }
            return false;
        }

    }
}
