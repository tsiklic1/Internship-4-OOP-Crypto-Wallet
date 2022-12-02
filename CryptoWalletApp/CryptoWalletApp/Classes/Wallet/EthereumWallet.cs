﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWalletApp.Classes.Wallet
{
    public abstract class EthereumWallet : AbleToInteractWithNonFungibleAssetWallet
    {
        public EthereumWallet() : base() { }
    }
}