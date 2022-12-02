using CryptoWalletApp.Classes.Asset;
using CryptoWalletApp.Classes.Wallet;
using System;
using System.Runtime.CompilerServices;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
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

            var fungibleAssetList = new List<FungibleAsset>()
            {
                bitcoin, ethereum, tether, bnb, dogecoin, cardano, polygon, polkadot, dai, usdcoin
            };

            var listOfLabels = new List<string>()
            {
                bitcoin.Label, ethereum.Label, tether.Label, bnb.Label, dogecoin.Label, cardano.Label, polygon.Label,
                polkadot.Label, dai.Label, usdcoin.Label
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

            var nonFungibleAssetList = new List<NonFungibleAsset>()
            {
                regularApe, punkApe, devilApe, shyApe, bunnyApe, redApe, russianApe, sailorApe, pirateApe,
                blindApe, greenApe, sleepyApe, detectiveApe, holyApe, partyApe, cowboyApe, karateApe, soldierApe,
                skeletonApe, blueApe
            };

            //9 walleta - po 3 btc, eth, sol
            //bitcoin walleti


            var bitcoinWallet1 = new BitcoinWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>()
                {
                    bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress,
                }
            };
            bitcoinWallet1.AddBalanceOfFungibleAsset(bitcoin.Adress, 8);

            var bitcoinWallet2 = new BitcoinWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>()
                {
                    bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress,
                }
            };
            bitcoinWallet2.AddBalanceOfFungibleAsset(dogecoin.Adress, 9000);

            var bitcoinWallet3 = new BitcoinWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>()
                {
                    bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress,
                }
            };
            bitcoinWallet3.AddBalanceOfFungibleAsset(ethereum.Adress, 50);

            var bitcoinWalletSupportedLabelsList = new List<string>()
            {
                bitcoin.Label, ethereum.Label, dogecoin.Label, usdcoin.Label
            };

            //ethereum walleti

            var ethereumWallet1 = new EthereumWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>
                {
                    bitcoin.Adress, ethereum.Adress, tether.Adress, bnb.Adress, cardano.Adress
                },
                AdressesOfSupportedNonFungibleAssets = new List<Guid>
                {
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, shyApe.Adress, bunnyApe.Adress, regularApe.Adress
                }

            
            };
            ethereumWallet1.AddSupportedFungibleAsset(bitcoin.Adress);
            ethereumWallet1.AddSupportedFungibleAsset(ethereum.Adress);
            ethereumWallet1.AddSupportedFungibleAsset(tether.Adress);
            ethereumWallet1.AddSupportedFungibleAsset(bnb.Adress);
            ethereumWallet1.AddSupportedFungibleAsset(cardano.Adress);
            ethereumWallet1.AddBalanceOfFungibleAsset(ethereum.Adress, 10);
            ethereumWallet1.AddSupportedNonFungibleAsset(regularApe.Adress);

            var ethereumWallet2 = new EthereumWallet() { };
            ethereumWallet2.AddSupportedFungibleAsset(bitcoin.Adress);
            ethereumWallet2.AddSupportedFungibleAsset(ethereum.Adress);
            ethereumWallet2.AddSupportedFungibleAsset(tether.Adress);
            ethereumWallet2.AddSupportedFungibleAsset(bnb.Adress);
            ethereumWallet2.AddSupportedFungibleAsset(cardano.Adress);
            ethereumWallet2.AddBalanceOfFungibleAsset(bitcoin.Adress, 2);

            var ethereumWallet3 = new EthereumWallet() { };
            ethereumWallet3.AddSupportedFungibleAsset(bitcoin.Adress);
            ethereumWallet3.AddSupportedFungibleAsset(ethereum.Adress);
            ethereumWallet3.AddSupportedFungibleAsset(tether.Adress);
            ethereumWallet3.AddSupportedFungibleAsset(bnb.Adress);
            ethereumWallet3.AddSupportedFungibleAsset(cardano.Adress);
            ethereumWallet3.AddBalanceOfFungibleAsset(tether.Adress, 3400);

            var ethereumWalletSupportedLabelsList = new List<string>()
            {
                bitcoin.Label, ethereum.Label, tether.Label, bnb.Label, cardano.Label
            };

            //solana walleti

            var solanaWallet1 = new SolanaWallet() { };
            solanaWallet1.AddSupportedFungibleAsset(bitcoin.Adress);
            solanaWallet1.AddSupportedFungibleAsset(ethereum.Adress);
            solanaWallet1.AddSupportedFungibleAsset(polygon.Adress);
            solanaWallet1.AddSupportedFungibleAsset(polkadot.Adress);
            solanaWallet1.AddSupportedFungibleAsset(dai.Adress);
            solanaWallet1.AddBalanceOfFungibleAsset(polygon.Adress, 3000);

            var solanaWallet2 = new SolanaWallet() { };
            solanaWallet2.AddSupportedFungibleAsset(bitcoin.Adress);
            solanaWallet2.AddSupportedFungibleAsset(ethereum.Adress);
            solanaWallet2.AddSupportedFungibleAsset(polygon.Adress);
            solanaWallet2.AddSupportedFungibleAsset(polkadot.Adress);
            solanaWallet2.AddSupportedFungibleAsset(dai.Adress);
            solanaWallet2.AddBalanceOfFungibleAsset(bitcoin.Adress, 11);

            var solanaWallet3 = new SolanaWallet() { };
            solanaWallet3.AddSupportedFungibleAsset(bitcoin.Adress);
            solanaWallet3.AddSupportedFungibleAsset(ethereum.Adress);
            solanaWallet3.AddSupportedFungibleAsset(polygon.Adress);
            solanaWallet3.AddSupportedFungibleAsset(polkadot.Adress);
            solanaWallet3.AddSupportedFungibleAsset(dai.Adress);
            solanaWallet3.AddBalanceOfFungibleAsset(dai.Adress, 4333);

            var solanaWalletSupportedLabelsList = new List<string>()
            {
                bitcoin.Label, ethereum.Label, polygon.Label, polkadot.Label, dai.Label
            };

            var listOfBitcoinWallets = new List<BitcoinWallet>()
            {
                bitcoinWallet1, bitcoinWallet2, bitcoinWallet3
            };

            var listOfEthereumWallets = new List<EthereumWallet>()
            {
                ethereumWallet1, ethereumWallet2, ethereumWallet3
            };

            var listOfSolanaWallets = new List<SolanaWallet>()
            {
                solanaWallet1, solanaWallet2, solanaWallet3
            };

            var listOfWallets = new List<Wallet>()  //mozda bude tribala ova lista svih walleta
            {
                bitcoinWallet1
            };

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
                        //---------------------------------------------
                        var newBitcoinWallet = new BitcoinWallet()
                        {
                            AdressesOfSupportedFungibleAssets = new List<Guid>()
                            {
                                bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress,
                            }
                        };
                        Console.WriteLine("Podrzani fungible asseti za bitcoin wallet su: ");
                        foreach (var item1 in bitcoinWallet1.AdressesOfSupportedFungibleAssets) //ovo moze u funkciju valjda
                        {
                            foreach (var item2 in fungibleAssetList)
                            {
                                if (item2.Adress == item1)
                                {
                                    Console.WriteLine($"Ime: {item2.Name} oznaka: {item2.Label}, adresa: {item1}");
                                }
                            }
                        }

                        Console.WriteLine("Unesite sve oznake fungible asseta kojem zelite postaviti pocetni balans (odvojene razmakom)");
                        var stringOfLabels = Console.ReadLine();
                        string[] labelsSplitList = stringOfLabels.Split(" ");

                        foreach (var label in labelsSplitList)
                        {
                            if (!bitcoinWalletSupportedLabelsList.Contains(label))
                            {
                                Console.WriteLine($"Fungible asset s labelom {label} nije podrzan u bitcoin walletu");
                            }
                            else
                            {
                                Console.WriteLine($"Unesite koliko {label} zelite postaviti");
                                decimal decimalOutput;
                                var amount = Console.ReadLine();
                                bool isDecimal = decimal.TryParse(amount, out decimalOutput);
                                if (!isDecimal)
                                {
                                    Console.WriteLine("To nije pravilan unos");
                                }
                                else
                                {
                                    // sad se unila količina triba pronać odgovarajući asset i stavit količinu
                                    foreach (var asset in fungibleAssetList)
                                    {
                                        if (asset.Label == label)
                                        {
                                            newBitcoinWallet.AddBalanceOfFungibleAsset(asset.Adress, decimalOutput);
                                        }
                                    }
                                }
                            }
                        }

                        Console.WriteLine("Ako zelite potvrditi stvaranje novog walleta upisite DA");
                        var confirmation = Console.ReadLine();
                        if (confirmation == "DA")
                        {
                            listOfBitcoinWallets.Add(newBitcoinWallet);
                        }
                        else
                            Console.WriteLine("Akcija ponistena");
                        

                        //---------------------------------------------
                        break;
                    case "2":
                        Console.WriteLine("Odabrali ste izbor 2 - Ethereum wallet");

                        break;
                    case "3":
                        Console.WriteLine("Odabrali ste izbor 3 - Solana wallet");

                        break;
                    default:
                        Console.WriteLine("Niste odabrali valjan izbor i vraceni ste na pocetni izbornik.\n");
                        break;
                }
            }




        }
    }
}