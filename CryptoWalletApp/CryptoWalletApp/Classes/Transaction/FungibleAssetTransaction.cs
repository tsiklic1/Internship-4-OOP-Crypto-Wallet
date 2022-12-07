using CryptoWalletApp.Classes.Asset;

namespace CryptoWalletApp.Classes.Transaction
{
    public class FungibleAssetTransaction : Transaction
    { 
        public decimal StartBalanceOfDonor { get; set; }
        public decimal EndBalanceOfDonor { get; set; }
        public decimal StartBalanceOfReceiver { get; set; }
        public decimal EndBalanceOfReceiver { get; set; }

        public decimal AmountOfFungibleAsset { get; set; }

        public string NameOfFungibleAsset { get; set; } = "";

        public FungibleAssetTransaction(Guid adressOfAsset, Guid adressOfDonor, Guid adressOfReceiver) : base(adressOfAsset, adressOfDonor, adressOfReceiver){}

        public override string ToString()
        {
            return base.ToString() + $"Kolicina fungible asseta: {AmountOfFungibleAsset}\nFungible asset ime: {NameOfFungibleAsset}\nJe li opozvana: {WasRevoked}\n";
        }

        public override void GetFungibleAssetName(List<FungibleAsset> fFungibleAssetList)
        {
            foreach (var item in fFungibleAssetList)
            {
                if (item.Adress == AdressOfAsset)
                {
                    NameOfFungibleAsset = item.Name;

                }
            }
        }
        
    }
}
