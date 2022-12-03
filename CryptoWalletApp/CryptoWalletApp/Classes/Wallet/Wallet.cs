using CryptoWalletApp.Classes.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Wallet
{
    public class Wallet  //abstract
    {
        public Guid Adress { get; }
        public Dictionary<Guid, decimal> BalancesOfFungibleAsset { get; private set; } //mozda samo set
        public List<Guid> AdressesOfSupportedFungibleAssets { get; set; } /*= new List<Guid>();*/ //{ get; private set; }  //ovo je isto za sve wallete istog tipa (BTC, ETH, ...)
        public List<Guid> AdressesOfTransactions { get; private set; }

        public Wallet()
        {
            Adress = Guid.NewGuid();
            BalancesOfFungibleAsset = new Dictionary<Guid, decimal>();
            AdressesOfTransactions = new List<Guid>();
            AdressesOfSupportedFungibleAssets= new List<Guid>();

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


    }
}
