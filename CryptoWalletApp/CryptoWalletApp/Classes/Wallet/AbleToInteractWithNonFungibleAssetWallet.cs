using CryptoWalletApp.Classes.Asset;
namespace CryptoWalletApp.Classes.Wallet
{
    public class AbleToInteractWithNonFungibleAssetWallet : Wallet  //abstract
    {
        public List<Guid> AdressesOfOwnedNonFungibleAssets { get; set; }
        public List<Guid> AdressesOfSupportedNonFungibleAssets { get; set; }  

        public decimal TotalValueOfNonFungibleAssetsInUSD { get; set; } = 0;

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

        public virtual bool RemoveNonFungibleAsset(Guid nonFungibleAsset)
        {
            if (!AdressesOfOwnedNonFungibleAssets.Contains(nonFungibleAsset))
            {
                return false;
            }
            AdressesOfOwnedNonFungibleAssets.Remove(nonFungibleAsset);
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

        public override decimal CalculateTotalValueOfFungibleAssetsInUSD(List<FungibleAsset> fungibleAssetList)
        {
            return base.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
        }

        public virtual decimal CalculateTotalValueOfNonFungibleAssetsInUSD(List<NonFungibleAsset> nonFungibleAssetList, List<FungibleAsset> fungibleAssetList)
        {
            decimal sum = 0;
            foreach (var item in AdressesOfOwnedNonFungibleAssets)
            {
                foreach (var item2 in nonFungibleAssetList)
                {
                    if (item == item2.Adress) 
                    {
                        foreach (var item3 in fungibleAssetList)
                        {
                            if (item2.AdressOfSpecificFungibleAsset == item3.Adress)
                            {
                                sum += item2.ValueInRelationToSpecificFungibleAsset * item3.ValueInRelationToDollar;
                            }
                        }
                    }
                }
            }
            TotalValueOfNonFungibleAssetsInUSD = sum;
            return sum;
        }

        public override string ToString()
        {
            if (HistoryOfValuesInUSD.Count() == 2)
            {
                return $"Adresa: {Adress}\nUkupna vrijednost u USD: {TotalValueOfFungibleAssetsInUSD + TotalValueOfNonFungibleAssetsInUSD}\nPostotak promjene u odnosu na prosli put 0";

            }
            return $"Adresa: {Adress}\nUkupna vrijednost u USD: {TotalValueOfFungibleAssetsInUSD + TotalValueOfNonFungibleAssetsInUSD}\nPostotak promjene u odnosu na prosli put {(HistoryOfValuesInUSD[HistoryOfValuesInUSD.Count() - 1] - HistoryOfValuesInUSD[HistoryOfValuesInUSD.Count() - 2])/HistoryOfValuesInUSD[HistoryOfValuesInUSD.Count() - 2]}";
        }
        public override void UpdateHistoryOfValues()
        {
            HistoryOfValuesInUSD.Add(TotalValueOfFungibleAssetsInUSD + TotalValueOfNonFungibleAssetsInUSD);
        }
    }
}
