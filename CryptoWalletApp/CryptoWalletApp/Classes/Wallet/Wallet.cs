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
            BalancesOfFungibleAsset = new Dictionary<Guid, decimal>();
            AdressesOfSupportedFungibleAssets = new List<Guid>();
            AdressesOfTransactions = new List<Guid>();

        }

        public virtual bool AddSupportedFungibleAsset(Guid newFungibleAsset)
        {
            if (AdressesOfSupportedFungibleAssets.Contains(newFungibleAsset))
            {
                return false;
            }
            AdressesOfSupportedFungibleAssets.Add(newFungibleAsset);
            BalancesOfFungibleAsset.Add(newFungibleAsset, 0);
            return true;
        }

        public virtual bool AddBalanceOfFungibleAsset(Guid fungibleAsset, decimal amountOfFungibleAssetToBeAdded)
        {
            var adressExists = false;
            foreach (var item in BalancesOfFungibleAsset)
            {
                if (item.Key == fungibleAsset)
                {
                    BalancesOfFungibleAsset[fungibleAsset] += amountOfFungibleAssetToBeAdded;
                    adressExists = true;
                }
            }
            if (adressExists)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
