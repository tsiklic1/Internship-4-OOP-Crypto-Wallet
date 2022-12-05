using CryptoWalletApp.Classes.Asset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Transaction
{
    public class NonFungibleAssetTransaction : Transaction
    {
        public string NameOfNonFungibleAsset { get; set; } = "";
        public NonFungibleAssetTransaction(Guid adressOfAsset, Guid adressOfDonor, Guid adressOfReceiver) : base(adressOfAsset, adressOfDonor, adressOfReceiver) { }

        public override string ToString()
        {
            return base.ToString() + $"\nIme non fungible asseta: {NameOfNonFungibleAsset}\nJe li opozvana: {WasRevoked}"; //ime non fungible asseta
        }

        public override void GetNonFungibleAssetName(List<NonFungibleAsset> fNonFungibleAssetList)
        {            
            foreach (var item in fNonFungibleAssetList)
            {
                if (item.Adress == AdressOfAsset)
                {
                    NameOfNonFungibleAsset = item.Name;

                }
            }
            
        }
    }

    
}
