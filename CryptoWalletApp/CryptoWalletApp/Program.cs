using CryptoWalletApp.Classes.Asset;
using CryptoWalletApp.Classes.Wallet;
using System;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bitcoinWallet = new BitcoinWallet()
            {

            };


            var bitcoin1 = new FungibleAsset(200000)
            {
                Name = "Bitcion",
                Label = "BTC",

            };


            //10 fungible asseta
            var bitcoin = new FungibleAsset(16000)
            {
                Name = "Bitcoin",
                Label = "BTC"
            };

            var ethereum = new FungibleAsset(1207)
            {
                Name = "Ethereum",
                Label = "ETH"
            };

            var tether = new FungibleAsset(1)
            {
                Name = "Tether",
                Label = "USDT"
            };

            var bnb = new FungibleAsset(299)
            {
                Name = "BNB",
                Label = "BNB"
            };

            var dogecoin = new FungibleAsset(0.1m)
            {
                Name = "Dogecoin",
                Label = "DOGE"
            };

            var cardano = new FungibleAsset(0.3m)
            {
                Name = "Cardano",
                Label = "ADA"
            };

            var polygon = new FungibleAsset(0.83m)
            {
                Name = "Polygon",
                Label = "MATIC"
            };

            var polkadot = new FungibleAsset(5.26m)
            {
                Name = "Polkadot",
                Label = "DOT"
            };

            var dai = new FungibleAsset(1)
            {
                Name = "Dai",
                Label = "DAI"
            };

            var usdcoin = new FungibleAsset(1)
            {
                Name = "USD coin",
                Label = "USDC"
            };

            //20 Non Fungible asseta
            //0
            var regularApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Regular ape",
                ValueInRelationToSpecificFungibleAsset = 1m
            };

            //1
            var punkApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Punk ape",
                ValueInRelationToSpecificFungibleAsset = 20m
            };

            //2
            var devilApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Devil ape",
                ValueInRelationToSpecificFungibleAsset = 1.3m
            };

            //3
            var shyApe = new NonFungibleAsset(dogecoin.Adress)
            {
                Name = "Shy ape",
                ValueInRelationToSpecificFungibleAsset = 30000m
            };

            //4
            var bunnyApe = new NonFungibleAsset(bnb.Adress)
            {
                Name = "Bunny ape",
                ValueInRelationToSpecificFungibleAsset = 30m
            };

            //5
            var redApe = new NonFungibleAsset(polygon.Adress)
            {
                Name = "Red ape",
                ValueInRelationToSpecificFungibleAsset = 14000m
            };

            //6
            var russianApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Russian ape",
                ValueInRelationToSpecificFungibleAsset = 0.8m
            };

            //7
            var sailorApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Sailor ape",
                ValueInRelationToSpecificFungibleAsset = 1m
            };

            //8
            var pirateApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Pirate ape",
                ValueInRelationToSpecificFungibleAsset = 14m
            };

            //9
            var blindApe = new NonFungibleAsset(cardano.Adress)
            {
                Name = "Blined ape",
                ValueInRelationToSpecificFungibleAsset = 700m
            };

            //10
            var greenApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Green ape",
                ValueInRelationToSpecificFungibleAsset = 12m
            };

            //11
            var sleepyApe = new NonFungibleAsset(cardano.Adress)
            {
                Name = "Sleepy ape",
                ValueInRelationToSpecificFungibleAsset = 11m
            };

            //12
            var detectiveApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Detective ape",
                ValueInRelationToSpecificFungibleAsset = 1.7m
            };

            //13
            var holyApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Holy ape",
                ValueInRelationToSpecificFungibleAsset = 2m
            };

            //14
            var partyApe = new NonFungibleAsset(dogecoin.Adress)
            {
                Name = "Party ape",
                ValueInRelationToSpecificFungibleAsset = 1000m
            };

            //15
            var cowboyApe = new NonFungibleAsset(usdcoin.Adress)
            {
                Name = "Cowboy ape",
                ValueInRelationToSpecificFungibleAsset = 20000m
            };

            //16
            var karateApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Karate ape",
                ValueInRelationToSpecificFungibleAsset = 1m
            };

            //17
            var soldierApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Soldier ape",
                ValueInRelationToSpecificFungibleAsset = 90m
            };

            //18
            var skeletonApe = new NonFungibleAsset(polkadot.Adress)
            {
                Name = "Skeleton ape",
                ValueInRelationToSpecificFungibleAsset = 1000m
            };

            //19
            var blueApe = new NonFungibleAsset(polkadot.Adress)
            {
                Name = "Blue ape",
                ValueInRelationToSpecificFungibleAsset = 543m
            };

            //9 walleta - po 3 btc, eth, sol

            var bitcoinWallet1 = new BitcoinWallet() { };
            bitcoinWallet1.AddSupportedFungibleAsset(bitcoin.Adress);
            bitcoinWallet1.AddSupportedFungibleAsset(ethereum.Adress);
            bitcoinWallet1.AddSupportedFungibleAsset(dogecoin.Adress);
            bitcoinWallet1.AddSupportedFungibleAsset(usdcoin.Adress);
            


            //odi triba kreirat 9 walleta, 10 fungible asseta i 20 non fungible asseta

            var choice = "";
            while (choice != "0")
            {
                Console.WriteLine("Nalazite se u izborniku Crypto novcanika. Vasi izbori su \n1 - Kreiraj wallet\n2 - Pristupi walletu\n0 - izlaz iz aplikacije");
                Console.WriteLine("Unesite zeljeni izbor");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Odabrali ste opciju 1 - Kreiraj wallet");
                        CreateWallet();
                        break;
                    case "2":
                        Console.WriteLine("Odabrali ste opciju 2 - Pristupi walletu");
                        break;
                    case "0":
                        Console.WriteLine("Izlaz");
                        break;
                    default:
                        Console.WriteLine("Niste unijeli valjani izbor.");
                        break;
                }



            }

            void CreateWallet()
            {
                Console.WriteLine("Odaberite koji wallet zelite kreirati.\n1 - Bitcoin wallet\n2 - Ethereum wallet\n3 - Solana wallet");
                var choiceOfWalletToCreate = Console.ReadLine();
                switch (choiceOfWalletToCreate)
                {
                    case "1":
                        Console.WriteLine("Odabrali ste izbor 1 - Bitcoin wallet");

                        break;
                    case "2":
                        break;
                    case "3":
                        break;

                    default:
                        Console.WriteLine("Niste odabrali valjan izbor i vraceni ste na pocetni izbornik.\n");
                        break;
                }
            }




        }
    }
}