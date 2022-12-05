using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Asset
{
    public class FungibleAsset : Asset
    {
        public string Label { get; set; } 
        public decimal ValueInRelationToDollar { get; private set; }
        public List<decimal> HistoryOfValuesInRelationToUSD { get; set; }

        public FungibleAsset(decimal valueInRelationToDollar) : base() 
        { 
            ValueInRelationToDollar= valueInRelationToDollar;
            HistoryOfValuesInRelationToUSD= new List<decimal>() {valueInRelationToDollar};
        }

        public override string ToString()
        {
            HistoryOfValuesInRelationToUSD.Add(ValueInRelationToDollar);
            return base.ToString() + $"\nOznaka: {Label}\nVrijednost u USD: {ValueInRelationToDollar}\nPostotak promjene od posljednjeg prikazivanja: {(HistoryOfValuesInRelationToUSD[HistoryOfValuesInRelationToUSD.Count() - 1] - HistoryOfValuesInRelationToUSD[HistoryOfValuesInRelationToUSD.Count() - 2]) / HistoryOfValuesInRelationToUSD[HistoryOfValuesInRelationToUSD.Count() - 2]}"; 
        }

        public string ToStringPercentageOfChangeSinceLastShowing()
        {
            HistoryOfValuesInRelationToUSD.Add(ValueInRelationToDollar);
            return $"{(HistoryOfValuesInRelationToUSD[HistoryOfValuesInRelationToUSD.Count() - 1] - HistoryOfValuesInRelationToUSD[HistoryOfValuesInRelationToUSD.Count() - 2]) / HistoryOfValuesInRelationToUSD[HistoryOfValuesInRelationToUSD.Count() - 2]}";
        }

        public void ChangeValueOfFungibleAssetRandomly()
        {
            System.Random random = new System.Random();
            decimal numRandom;
            numRandom = random.Next(-25,26);
            ValueInRelationToDollar *= 1 + numRandom / 1000;

        }
    }
}
