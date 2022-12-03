using CryptoWalletApp.Classes.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Wallet
{
    public class BitcoinWallet : Wallet
    {
        public BitcoinWallet() : base(){}

        public override bool AddSupportedFungibleAsset(Guid newFungibleAsset)
        {
            return base.AddSupportedFungibleAsset(newFungibleAsset);
        }
        public override bool AddBalanceOfFungibleAsset(Guid fungibleAsset, decimal amountOfFungibleAssetToBeAdded)
        {
            return base.AddBalanceOfFungibleAsset(fungibleAsset, amountOfFungibleAssetToBeAdded);
        }

        public override decimal CalculateTotalValueOfFungibleAssetsInUSD(List<FungibleAsset> fungibleAssetList)
        {
            return base.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
        }

        public override string ToString()
        {
            return "Bitcoin wallet\n" + base.ToString();
        }
        //public bool AddSupportedFungibleAsset(Guid fungibleAsset)
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
