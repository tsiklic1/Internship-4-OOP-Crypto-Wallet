using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Transaction
{
    public class FungibleAssetTransaction : Transaction
    { 
        public decimal StartBalanceOfDonor { get; set; }
        public decimal EndBalanceOfDonor { get; set; }
        public decimal StartBalanceOfReceiver { get; set; }
        public decimal EndBalanceOfReceiver { get; set; }
    }
}
