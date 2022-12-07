using CryptoWalletApp.Classes.Asset;

namespace CryptoWalletApp.Classes.Transaction
{
    public class Transaction
    {
        public Guid Id { get; }
        public Guid AdressOfAsset { get; }  
        public DateTime DateOfTransaction { get; }
        public Guid AdressOfDonor { get; }
        public Guid AdressOfReceiver { get; }
        public bool WasRevoked { get; set; }

        public Transaction(Guid adressOfAsset, Guid adressOfDonor, Guid adressOfReceiver)
        {
            Id = Guid.NewGuid();
            AdressOfAsset= adressOfAsset;
            AdressOfDonor= adressOfDonor;
            AdressOfReceiver = adressOfReceiver;
            DateOfTransaction = DateTime.Now;
            WasRevoked = false;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nDatum i vrijeme: {DateOfTransaction}\nAdresa donora: {AdressOfDonor}\nAdresa primatelja: {AdressOfReceiver}\n";
        }

        public virtual void GetFungibleAssetName(List<FungibleAsset> fFungibleAssetList) { }

        public virtual void GetNonFungibleAssetName(List<NonFungibleAsset> fNonFungibleAssetList) { }
    }
}
