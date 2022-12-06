
namespace CryptoWalletApp.Classes.Asset
{
    public class NonFungibleAsset : Asset
    {
        public decimal ValueInRelationToSpecificFungibleAsset { get; set; }
        public Guid AdressOfSpecificFungibleAsset { get; }

        public NonFungibleAsset(Guid adressOfSpecificFungibleAsset) : base()
        {
            AdressOfSpecificFungibleAsset= adressOfSpecificFungibleAsset;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nVrijednost u fungible assetu: {ValueInRelationToSpecificFungibleAsset}";
        }
    }
}
