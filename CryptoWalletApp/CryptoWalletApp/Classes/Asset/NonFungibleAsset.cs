using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
