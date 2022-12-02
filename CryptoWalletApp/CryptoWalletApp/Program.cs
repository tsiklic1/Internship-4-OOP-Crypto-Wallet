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

            var nft = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Bored Ape",
                ValueInRelationToSpecificFungibleAsset = 3,
            };

            //10 fungible asseta
            var bitcoin = new FungibleAsset(20000)
            {
                Name = "Bitcoin",
                Label = "BTC"
            };


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