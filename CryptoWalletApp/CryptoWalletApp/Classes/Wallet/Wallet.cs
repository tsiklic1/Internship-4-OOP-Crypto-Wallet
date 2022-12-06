using CryptoWalletApp.Classes.Asset;

namespace CryptoWalletApp.Classes.Wallet
{
    public class Wallet  //abstract
    {
        public Guid Adress { get; }
        public Dictionary<Guid, decimal> BalancesOfFungibleAsset { get; private set; } 
        public List<Guid> AdressesOfSupportedFungibleAssets { get; set; }
        public List<Guid> AdressesOfTransactions { get; private set; }
        public decimal TotalValueOfFungibleAssetsInUSD { get; set; } = 0;
        public List<decimal> HistoryOfValuesInUSD { get; set; }
        public Wallet()
        {
            Adress = Guid.NewGuid();
            BalancesOfFungibleAsset = new Dictionary<Guid, decimal>();
            AdressesOfTransactions = new List<Guid>();
            AdressesOfSupportedFungibleAssets= new List<Guid>();
            HistoryOfValuesInUSD= new List<decimal>() {0};
        }

        public virtual bool AddSupportedFungibleAsset(Guid newFungibleAsset)
        {
            if(AdressesOfSupportedFungibleAssets.Contains(newFungibleAsset))
            {
                return false;
            }
            AdressesOfSupportedFungibleAssets.Add(newFungibleAsset);
            BalancesOfFungibleAsset.Add(newFungibleAsset, 0);
            return true;
        }

        public virtual bool AddBalanceOfFungibleAsset(Guid fungibleAsset, decimal amountOfFungibleAssetToBeAdded)
        {
            if (!AdressesOfSupportedFungibleAssets.Contains(fungibleAsset))
            {
                Console.WriteLine($"Taj asset ({fungibleAsset}) nije podrzan u ovom walletu");
                return false;
            }
            if (BalancesOfFungibleAsset.ContainsKey(fungibleAsset))
            {
                BalancesOfFungibleAsset[fungibleAsset] += amountOfFungibleAssetToBeAdded;

            }
            else
            {
                BalancesOfFungibleAsset.Add(fungibleAsset, amountOfFungibleAssetToBeAdded);
            }
            return true;
        }

        public virtual decimal CalculateTotalValueOfFungibleAssetsInUSD(List<FungibleAsset> fungibleAssetList)
        {
            decimal sum = 0;
            foreach (var item in BalancesOfFungibleAsset)
            {
                foreach (var item2 in fungibleAssetList)
                {
                    if (item.Key == item2.Adress)
                    {
                        sum += item.Value * item2.ValueInRelationToDollar;
                    }
                }
            }
            TotalValueOfFungibleAssetsInUSD = sum;
            
            return sum;
        }

        public override string ToString()
        {
            if (HistoryOfValuesInUSD.Count() == 2)
            {
                return $"Adresa: {Adress}\nUkupna vrijednost u USD: {TotalValueOfFungibleAssetsInUSD}\nPostotak promjene u odnosu na prosli put 0";

            }
            return $"Adresa: {Adress}\nUkupna vrijednost u USD: {TotalValueOfFungibleAssetsInUSD}\nPostotak promjene u odnosu na prosli put {(HistoryOfValuesInUSD[HistoryOfValuesInUSD.Count() - 1] - HistoryOfValuesInUSD[HistoryOfValuesInUSD.Count() - 2])/ HistoryOfValuesInUSD[HistoryOfValuesInUSD.Count() - 2]}";
        }

        public virtual void UpdateHistoryOfValues()
        {
            HistoryOfValuesInUSD.Add(TotalValueOfFungibleAssetsInUSD);
        }

    }
}
