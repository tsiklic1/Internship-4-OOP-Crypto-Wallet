using CryptoWalletApp.Classes.Asset;

namespace CryptoWalletApp.Classes.Transaction
{
    public class NonFungibleAssetTransaction : Transaction
    {
        public string NameOfNonFungibleAsset { get; set; } = "";
        public NonFungibleAssetTransaction(Guid adressOfAsset, Guid adressOfDonor, Guid adressOfReceiver) : base(adressOfAsset, adressOfDonor, adressOfReceiver) { }

        public override string ToString()
        {
            return base.ToString() + $"Ime non fungible asseta: {NameOfNonFungibleAsset}\nJe li opozvana: {WasRevoked}\n"; 
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
