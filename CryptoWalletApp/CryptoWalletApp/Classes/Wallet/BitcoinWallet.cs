using CryptoWalletApp.Classes.Asset;

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

        public override void UpdateHistoryOfValues()
        {
            base.UpdateHistoryOfValues();
        }

    }
}
