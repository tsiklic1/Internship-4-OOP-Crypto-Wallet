using CryptoWalletApp.Classes.Asset;
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

        public override bool AddSupportedFungibleAsset(Guid newFungibleAsset)
        {
            return base.AddSupportedFungibleAsset(newFungibleAsset);
        }

        public override bool AddBalanceOfFungibleAsset(Guid fungibleAsset, decimal amountOfFungibleAssetToBeAdded)
        {
            return base.AddBalanceOfFungibleAsset(fungibleAsset, amountOfFungibleAssetToBeAdded);
        }
        
        public override bool AddSupportedNonFungibleAsset(Guid newNonFungibleAsset)
        {
            return base.AddSupportedNonFungibleAsset(newNonFungibleAsset);
        }

        public override bool AddNonFungibleAsset(Guid nonFungibleAsset)
        {
            return base.AddNonFungibleAsset(nonFungibleAsset);
        }

        public override bool DoesOwnNonFungibleAsset(Guid nonFungibleAsset)
        {
            return base.DoesOwnNonFungibleAsset(nonFungibleAsset);
        }

        public override decimal CalculateTotalValueOfNonFungibleAssetsInUSD(List<NonFungibleAsset> nonFungibleAssetList, List<FungibleAsset> fungibleAssetList)
        {
            return base.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);
        }

        public override string ToString()
        {
            return "Ethereum wallet\n" + base.ToString();
        }

        public override void UpdateHistoryOfValues()
        {
            base.UpdateHistoryOfValues();
        }

        //public override void RemoveNonFungibleAsset(Guid assetAdress)
        //{
        //    base.RemoveNonFungibleAsset(assetAdress);
        //}

        //public static bool AddSupportedFungibleAsset(Guid fungibleAsset)
        //{
        //    if (AdressesOfSupportedFungibleAssets.Contains(fungibleAsset))
        //    {
        //        return false;
        //    }
        //    AdressesOfSupportedFungibleAssets.Add(fungibleAsset);
        //    return true;
        //}

    }
}
