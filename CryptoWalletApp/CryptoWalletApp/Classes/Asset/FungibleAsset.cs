using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Asset
{
    public class FungibleAsset : Asset
    {
        public string Label { get; set; }  //triba dodat funkciju vjv static koja provjerava da nemaju 2 sa istin labelon i imenon‚ pogledaj borov CarStore
        public decimal ValueInRelationToDollar { get; private set; }

        public FungibleAsset(decimal valueInRelationToDollar) : base() 
        { 
            ValueInRelationToDollar= valueInRelationToDollar;

        }
    }
}
