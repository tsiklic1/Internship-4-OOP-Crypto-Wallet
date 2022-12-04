using CryptoWalletApp.Classes.Asset;
using CryptoWalletApp.Classes.Wallet;
using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

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
                Name = "Regular-Ape",
                ValueInRelationToSpecificFungibleAsset = 1m
            };

            //1
            var punkApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Punk-Ape",
                ValueInRelationToSpecificFungibleAsset = 20m
            };

            //2
            var devilApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Devil-Ape",
                ValueInRelationToSpecificFungibleAsset = 1.3m
            };

            //3
            var shyApe = new NonFungibleAsset(dogecoin.Adress)
            {
                Name = "Shy-Ape",
                ValueInRelationToSpecificFungibleAsset = 30000m
            };

            //4
            var bunnyApe = new NonFungibleAsset(bnb.Adress)
            {
                Name = "Bunny-Ape",
                ValueInRelationToSpecificFungibleAsset = 30m
            };

            //5
            var redApe = new NonFungibleAsset(polygon.Adress)
            {
                Name = "Red-Ape",
                ValueInRelationToSpecificFungibleAsset = 14000m
            };

            //6
            var russianApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Russian-Ape",
                ValueInRelationToSpecificFungibleAsset = 0.8m
            };

            //7
            var sailorApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Sailor-Ape",
                ValueInRelationToSpecificFungibleAsset = 1m
            };

            //8
            var pirateApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Pirate-Ape",
                ValueInRelationToSpecificFungibleAsset = 14m
            };

            //9
            var blindApe = new NonFungibleAsset(cardano.Adress)
            {
                Name = "Blind-Ape",
                ValueInRelationToSpecificFungibleAsset = 700m
            };

            //10
            var greenApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Green-Ape",
                ValueInRelationToSpecificFungibleAsset = 12m
            };

            //11
            var sleepyApe = new NonFungibleAsset(cardano.Adress)
            {
                Name = "Sleepy-Ape",
                ValueInRelationToSpecificFungibleAsset = 11m
            };

            //12
            var detectiveApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Detective-Ape",
                ValueInRelationToSpecificFungibleAsset = 1.7m
            };

            //13
            var holyApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Holy-Ape",
                ValueInRelationToSpecificFungibleAsset = 2m
            };

            //14
            var partyApe = new NonFungibleAsset(dogecoin.Adress)
            {
                Name = "Party-Ape",
                ValueInRelationToSpecificFungibleAsset = 1000m
            };

            //15
            var cowboyApe = new NonFungibleAsset(usdcoin.Adress)
            {
                Name = "Cowboy-Ape",
                ValueInRelationToSpecificFungibleAsset = 20000m
            };

            //16
            var karateApe = new NonFungibleAsset(bitcoin.Adress)
            {
                Name = "Karate-Ape",
                ValueInRelationToSpecificFungibleAsset = 1m
            };

            //17
            var soldierApe = new NonFungibleAsset(ethereum.Adress)
            {
                Name = "Soldier-Ape",
                ValueInRelationToSpecificFungibleAsset = 90m
            };

            //18
            var skeletonApe = new NonFungibleAsset(polkadot.Adress)
            {
                Name = "Skeleton-Ape",
                ValueInRelationToSpecificFungibleAsset = 1000m
            };

            //19
            var blueApe = new NonFungibleAsset(polkadot.Adress)
            {
                Name = "Blue-Ape",
                ValueInRelationToSpecificFungibleAsset = 543m
            };

            var nonFungibleAssetList = new List<NonFungibleAsset>()
            {
                regularApe, punkApe, devilApe, shyApe, bunnyApe, redApe, russianApe, sailorApe, pirateApe,
                blindApe, greenApe, sleepyApe, detectiveApe, holyApe, partyApe, cowboyApe, karateApe, soldierApe,
                skeletonApe, blueApe
            };

            Console.WriteLine(blueApe);


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
            bitcoinWallet1.AddBalanceOfFungibleAsset(usdcoin.Adress, 5);
            bitcoinWallet1.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                        
            var bitcoinWallet2 = new BitcoinWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>()
                {
                    bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress,
                }
            };
            bitcoinWallet2.AddBalanceOfFungibleAsset(dogecoin.Adress, 9000);
            bitcoinWallet2.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);

            var bitcoinWallet3 = new BitcoinWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>()
                {
                    bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress,
                }
            };
            bitcoinWallet3.AddBalanceOfFungibleAsset(ethereum.Adress, 50);
            bitcoinWallet3.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);

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
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, shyApe.Adress, bunnyApe.Adress
                }

            
            };
            ethereumWallet1.AddBalanceOfFungibleAsset(ethereum.Adress, 10);
            ethereumWallet1.AddNonFungibleAsset(regularApe.Adress);
            ethereumWallet1.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
            ethereumWallet1.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

            var ethereumWallet2 = new EthereumWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>
                {
                    bitcoin.Adress, ethereum.Adress, tether.Adress, bnb.Adress, cardano.Adress
                },
                AdressesOfSupportedNonFungibleAssets = new List<Guid>
                {
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, shyApe.Adress, bunnyApe.Adress
                }
            };
            ethereumWallet2.AddBalanceOfFungibleAsset(bitcoin.Adress, 2);
            ethereumWallet2.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
            ethereumWallet2.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

            var ethereumWallet3 = new EthereumWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>
                {
                    bitcoin.Adress, ethereum.Adress, tether.Adress, bnb.Adress, cardano.Adress
                },
                AdressesOfSupportedNonFungibleAssets = new List<Guid>
                {
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, shyApe.Adress, bunnyApe.Adress
                }
            };
            ethereumWallet3.AddBalanceOfFungibleAsset(tether.Adress, 3400);
            ethereumWallet3.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
            ethereumWallet3.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

            var ethereumWalletSupportedLabelsList = new List<string>()
            {
                bitcoin.Label, ethereum.Label, tether.Label, bnb.Label, cardano.Label
            };

            //solana walleti

            var solanaWallet1 = new SolanaWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>
                {
                    bitcoin.Adress, ethereum.Adress, polygon.Adress, dai.Adress, polkadot.Adress
                },
                AdressesOfSupportedNonFungibleAssets = new List<Guid> 
                {
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, bunnyApe.Adress, russianApe.Adress, pirateApe.Adress,
                    blindApe.Adress, greenApe.Adress
                }
            };
            solanaWallet1.AddBalanceOfFungibleAsset(polygon.Adress, 3000);
            solanaWallet1.AddNonFungibleAsset(punkApe.Adress);
            solanaWallet1.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
            solanaWallet1.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

            var solanaWallet2 = new SolanaWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>
                {
                    bitcoin.Adress, ethereum.Adress, polygon.Adress, dai.Adress, polkadot.Adress
                },
                AdressesOfSupportedNonFungibleAssets = new List<Guid>
                {
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, bunnyApe.Adress, russianApe.Adress, pirateApe.Adress,
                    blindApe.Adress, greenApe.Adress
                }
            };
            solanaWallet2.AddBalanceOfFungibleAsset(bitcoin.Adress, 11);
            solanaWallet2.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
            solanaWallet2.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

            var solanaWallet3 = new SolanaWallet() 
            {
                AdressesOfSupportedFungibleAssets = new List<Guid>
                {
                    bitcoin.Adress, ethereum.Adress, polygon.Adress, dai.Adress, polkadot.Adress
                },
                AdressesOfSupportedNonFungibleAssets = new List<Guid>
                {
                    regularApe.Adress, punkApe.Adress, devilApe.Adress, bunnyApe.Adress, russianApe.Adress, pirateApe.Adress,
                    blindApe.Adress, greenApe.Adress
                }
            };
            solanaWallet3.AddBalanceOfFungibleAsset(dai.Adress, 4333);
            solanaWallet3.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
            solanaWallet3.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

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
                        Console.WriteLine($"Broj bitcoin walleta: {listOfBitcoinWallets.Count}");
                        Console.WriteLine($"Broj ethereum walleta: {listOfEthereumWallets.Count}");
                        Console.WriteLine($"Broj solana walleta: {listOfSolanaWallets.Count}");

                        break;
                    case "2":
                        Console.WriteLine("Odabrali ste opciju 2 - Pristupi walletu");
                        AccessWallet();
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
                        var newBitcoinWallet = new BitcoinWallet()
                        {
                            AdressesOfSupportedFungibleAssets = new List<Guid>()
                            {
                                bitcoin.Adress, ethereum.Adress,dogecoin.Adress, usdcoin.Adress
                            }
                        };

                        Console.WriteLine("Podrzani fungible asseti za bitcoin wallet su: ");
                        PrintSupportedFungibleAssets(bitcoinWallet1.AdressesOfSupportedFungibleAssets, fungibleAssetList);

                        Console.WriteLine("Unesite sve oznake fungible asseta kojem zelite postaviti pocetni balans (odvojene razmakom)");
                        var stringOfLabels = Console.ReadLine();
                        string[] labelsSplitList = stringOfLabels.Split(" ");

                        foreach (var label in labelsSplitList)
                        {
                            newBitcoinWallet = (BitcoinWallet)SetValuesOfFungibleAsset(newBitcoinWallet, label, bitcoinWalletSupportedLabelsList);
                        }
                        newBitcoinWallet.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);

                        Console.WriteLine("Ako zelite potvrditi stvaranje novog walleta upisite DA");
                        var confirmation = Console.ReadLine();
                        if (confirmation == "DA")
                        {
                            Console.WriteLine(newBitcoinWallet.Adress);
                            listOfBitcoinWallets.Add(newBitcoinWallet);
                        }
                        else
                            Console.WriteLine("Akcija ponistena");
                        break;
                    case "2":
                        Console.WriteLine("Odabrali ste izbor 2 - Ethereum wallet");
                        var newEthereumWallet = new EthereumWallet()
                        {
                            AdressesOfSupportedFungibleAssets = new List<Guid>
                            {
                                bitcoin.Adress, ethereum.Adress, tether.Adress, bnb.Adress, cardano.Adress
                            },
                            AdressesOfSupportedNonFungibleAssets = new List<Guid>
                            {
                                regularApe.Adress, punkApe.Adress, devilApe.Adress, shyApe.Adress, bunnyApe.Adress
                            }
                        };

                        Console.WriteLine("Podrzani fungible asseti za ethereum wallet su");
                        PrintSupportedFungibleAssets(newEthereumWallet.AdressesOfSupportedFungibleAssets, fungibleAssetList);

                        Console.WriteLine("Unesite sve oznake fungible asseta kojem zelite postaviti pocetni balans (odvojene razmakom)");
                        var stringOfLabelsForEthereum = Console.ReadLine();
                        string[] labelsSplitListForEthereum = stringOfLabelsForEthereum.Split(" ");

                        foreach (var label in labelsSplitListForEthereum)
                        {
                            newEthereumWallet = (EthereumWallet)SetValuesOfFungibleAsset(newEthereumWallet, label, ethereumWalletSupportedLabelsList);
                        }

                        Console.WriteLine("\nPodrzani non fungible asseti za ethereum wallet su: ");
                        PrintSupportedNonFungibleAssets(newEthereumWallet.AdressesOfSupportedNonFungibleAssets, nonFungibleAssetList);

                        Console.WriteLine("Unesite sva imena non fungible asseta koja zelite postaviti u wallet");
                        var stringOfNonFungibleAssetsForEthereum = Console.ReadLine();
                        string[] nonFungibleAssetsNamesListForEthereum = stringOfNonFungibleAssetsForEthereum.Split(" ");

                        foreach (var name in nonFungibleAssetsNamesListForEthereum)
                        {
                            Guid adressEth = new Guid();

                            foreach (var item in nonFungibleAssetList)
                            {
                                if (name == item.Name)
                                {
                                    adressEth = item.Adress;
                                }
                            }


                            var isAlreadyOwnedEth = CheckIfNonFungibleAssetIsAlreadyOwned(name, nonFungibleAssetList, listOfEthereumWallets, listOfSolanaWallets);

                            if (!isAlreadyOwnedEth) 
                            {                                
                                newEthereumWallet.AddNonFungibleAsset(adressEth);
                            }
                            else
                            {
                                Console.WriteLine($"Netko vec posjeduje {name} pa on nije dodan u novi wallet.");
                            }
                            
                        }
                        newEthereumWallet.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                        newEthereumWallet.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

                        Console.WriteLine("Ako zelite potvrditi stvaranje novog walleta upisite DA");
                        var confirmationForEthereum = Console.ReadLine();
                        if (confirmationForEthereum == "DA")
                        {
                            listOfEthereumWallets.Add(newEthereumWallet);
                        }
                        else
                            Console.WriteLine("Akcija ponistena");
                        break;
                    case "3":
                        Console.WriteLine("Odabrali ste izbor 3 - Solana wallet");
                        var newSolanaWallet = new SolanaWallet()
                        {
                            AdressesOfSupportedFungibleAssets = new List<Guid>
                            {
                                bitcoin.Adress, ethereum.Adress, polygon.Adress, dai.Adress, polkadot.Adress
                            },
                            AdressesOfSupportedNonFungibleAssets = new List<Guid>
                            {
                                regularApe.Adress, punkApe.Adress, devilApe.Adress, bunnyApe.Adress, russianApe.Adress, pirateApe.Adress,
                                blindApe.Adress, greenApe.Adress
                            }
                        };

                        Console.WriteLine("Podrzani fungible asseti za solana wallet su");
                        PrintSupportedFungibleAssets(newSolanaWallet.AdressesOfSupportedFungibleAssets, fungibleAssetList);

                        Console.WriteLine("Unesite sve oznake fungible asseta kojem zelite postaviti pocetni balans (odvojene razmakom)");
                        var stringOfLabelsForSolana = Console.ReadLine();
                        string[] labelsSplitListForSolana = stringOfLabelsForSolana.Split(" ");

                        foreach (var label in labelsSplitListForSolana)
                        {
                            newSolanaWallet = (SolanaWallet)SetValuesOfFungibleAsset(newSolanaWallet, label, solanaWalletSupportedLabelsList);
                        }

                        Console.WriteLine("\nPodrzani non fungible asseti za ethereum wallet su: ");
                        PrintSupportedNonFungibleAssets(newSolanaWallet.AdressesOfSupportedNonFungibleAssets, nonFungibleAssetList);

                        Console.WriteLine("Unesite sva imena non fungible asseta koja zelite postaviti u wallet");
                        var stringOfNonFungibleAssetsForSolana = Console.ReadLine();
                        string[] nonFungibleAssetsNamesListForSolana = stringOfNonFungibleAssetsForSolana.Split(" ");

                        foreach (var name in nonFungibleAssetsNamesListForSolana)
                        {
                            Guid adressSol = new Guid();

                            foreach (var item in nonFungibleAssetList)
                            {
                                if (name == item.Name)
                                {
                                    adressSol = item.Adress;
                                }
                            }

                            var isAlreadyOwnedSol = CheckIfNonFungibleAssetIsAlreadyOwned(name, nonFungibleAssetList, listOfEthereumWallets, listOfSolanaWallets);

                            if (!isAlreadyOwnedSol)
                            {
                                newSolanaWallet.AddNonFungibleAsset(adressSol);
                            }
                            else
                            {
                                Console.WriteLine($"Netko vec posjeduje {name} pa on nije dodan u novi wallet.");
                            }
                        }
                        newSolanaWallet.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                        newSolanaWallet.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);

                        Console.WriteLine("Ako zelite potvrditi stvaranje novog walleta upisite DA");
                        var confirmationForSolana = Console.ReadLine();
                        if (confirmationForSolana == "DA")
                        {
                            listOfSolanaWallets.Add(newSolanaWallet);
                        }
                        else
                            Console.WriteLine("Akcija ponistena");
                        break;
                    default:
                        Console.WriteLine("Niste odabrali valjan izbor i vraceni ste na pocetni izbornik.\n");
                        break;
                }
            }

            void AccessWallet()
            {
                Console.WriteLine("Trenutno dostupni walleti su: ");
                foreach (var item in listOfBitcoinWallets)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                foreach (var item in listOfEthereumWallets)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                foreach (var item in listOfSolanaWallets)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");

                Console.WriteLine("Unesite adresu walleta koji zelite koristiti");
                Guid guidOutput;
                var adressOfWallet = Console.ReadLine();
                bool isGuid = Guid.TryParse(adressOfWallet, out guidOutput);

                if (!isGuid)
                {
                    Console.WriteLine("Niste unijeli adresu ispravno");
                }
                else
                {
                    var choiceOfSubmenu = "";
                    while (choiceOfSubmenu != "0")
                    {
                        Console.WriteLine("Submenu:\n1 - Portfolio\n2 - Transfer\n3 - Povijest transakcija\n0 - Povratak na inicijalni menu");
                        choiceOfSubmenu= Console.ReadLine();
                        switch (choiceOfSubmenu)
                        {
                            case "1":
                                Portfolio(guidOutput);
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            void Portfolio(Guid fGuidOutput)
            {
                foreach (var item in listOfBitcoinWallets)  //ovo ide samo u bitcoin wallete, triba ponovit za eth i sol
                {
                    if (fGuidOutput == item.Adress)
                    {
                        Console.WriteLine($"Ukupna vrijednost walleta u USD: { item.TotalValueOfFungibleAssetsInUSD}");
                        foreach (var item1 in item.BalancesOfFungibleAsset)
                        {
                            foreach (var item2 in fungibleAssetList)
                            {
                                if (item1.Key == item2.Adress)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(item2);
                                    Console.WriteLine($"Ukupna vrijednost u USD: {item2.ValueInRelationToDollar * item1.Value}");

                                }
                            }
                        }
                    }
                }

                foreach (var item in listOfEthereumWallets)  //ovo ide u eth wallete
                {
                    if (fGuidOutput == item.Adress)
                    {
                        Console.WriteLine($"Ukupna vrijednost walleta u USD: {item.TotalValueOfNonFungibleAssetsInUSD + item.TotalValueOfFungibleAssetsInUSD}");
                        foreach (var item1 in item.BalancesOfFungibleAsset)
                        {
                            foreach (var item2 in fungibleAssetList)
                            {
                                if (item1.Key == item2.Adress)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(item2);
                                    Console.WriteLine($"Ukupna vrijednost u USD: {item2.ValueInRelationToDollar * item1.Value}");
                                }
                            }
                        }
                        foreach (var adress in item.AdressesOfOwnedNonFungibleAssets)
                        {
                            foreach (var asset in nonFungibleAssetList)
                            {
                                if (adress == asset.Adress)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(asset);
                                    //Console.WriteLine($"Ukupna vrijednost u USD {asset.ValueInRelationToSpecificFungibleAsset*asset.}");
                                    foreach (var fungibleAsset in fungibleAssetList)
                                    {
                                        if (fungibleAsset.Adress == asset.AdressOfSpecificFungibleAsset)
                                        {
                                            Console.WriteLine($"Ukupna vrijednost u USD {fungibleAsset.ValueInRelationToDollar}");
                                            Console.WriteLine($"Postotak promjene pripadnog fungible asseta u odnosu na zadnje prikazivanje {fungibleAsset.ToStringPercentageOfChangeSinceLastShowing()}");
                                        }
                                    }
                                }
                            }
                        }
                    
                    }
                }

                foreach (var item in listOfSolanaWallets)  //ovo ide u sol wallete
                {
                    if (fGuidOutput == item.Adress)
                    {
                        Console.WriteLine($"Ukupna vrijednost walleta u USD: {item.TotalValueOfNonFungibleAssetsInUSD + item.TotalValueOfFungibleAssetsInUSD}");
                        foreach (var item1 in item.BalancesOfFungibleAsset)
                        {
                            foreach (var item2 in fungibleAssetList)
                            {
                                if (item1.Key == item2.Adress)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(item2);
                                    Console.WriteLine($"Ukupna vrijednost u USD: {item2.ValueInRelationToDollar * item1.Value}");
                                }
                            }
                        }
                        foreach (var adress in item.AdressesOfOwnedNonFungibleAssets)
                        {
                            foreach (var asset in nonFungibleAssetList)
                            {
                                if (adress == asset.Adress)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(asset);
                                    //Console.WriteLine($"Ukupna vrijednost u USD {asset.ValueInRelationToSpecificFungibleAsset*asset.}");
                                    foreach (var fungibleAsset in fungibleAssetList)
                                    {
                                        if (fungibleAsset.Adress == asset.AdressOfSpecificFungibleAsset)
                                        {
                                            Console.WriteLine($"Ukupna vrijednost u USD {fungibleAsset.ValueInRelationToDollar}");
                                            Console.WriteLine($"Postotak promjene pripadnog fungible asseta u odnosu na zadnje prikazivanje {fungibleAsset.ToStringPercentageOfChangeSinceLastShowing()}");
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }

            void PrintSupportedFungibleAssets(List<Guid> supportedAdresses, List<FungibleAsset> assetList)
            {
                foreach (var item1 in supportedAdresses) 
                {
                    foreach (var item2 in assetList)
                    {
                        if (item2.Adress == item1)
                        {
                            Console.WriteLine($"Ime: {item2.Name} oznaka: {item2.Label}, adresa: {item1}");
                        }
                    }
                }
            }

            void PrintSupportedNonFungibleAssets(List<Guid> supportedAdresses, List<NonFungibleAsset> assetList)
            {
                foreach (var item1 in supportedAdresses) 
                {
                    foreach (var item2 in assetList)
                    {
                        if (item2.Adress == item1)
                        {
                            Console.WriteLine($"Ime: {item2.Name}, adresa: {item1}");
                        }
                    }
                }
            }

            bool CheckIfNonFungibleAssetIsAlreadyOwned(string fName, List<NonFungibleAsset> fNonFungibleAssetList, List<EthereumWallet> fListOfEthereumWallets, List<SolanaWallet> fListOfSolanaWallets)
            {
                var isAlreadyOwnedEth = false;

                foreach (var nonFungibleAsset in fNonFungibleAssetList)
                {
                    if (nonFungibleAsset.Name == fName)
                    {
                        foreach (var wallet in fListOfEthereumWallets)
                        {
                            if (wallet.DoesOwnNonFungibleAsset(nonFungibleAsset.Adress))
                            {
                                isAlreadyOwnedEth = true;
                            }
                        }
                        foreach (var wallet in fListOfSolanaWallets)
                        {
                            if (wallet.DoesOwnNonFungibleAsset(nonFungibleAsset.Adress))
                            {
                                isAlreadyOwnedEth = true;
                            }
                        }
                    }
                }
                return isAlreadyOwnedEth;
            }

            Wallet SetValuesOfFungibleAsset(Wallet newWallet, string fLabel, List<string> supportedLabelsList)
            {
                if (!supportedLabelsList.Contains(fLabel))
                {
                    Console.WriteLine($"Fungible asset s labelom {fLabel} nije podrzan u bitcoin walletu");
                }
                else
                {
                    Console.WriteLine($"Unesite koliko {fLabel} zelite postaviti");
                    decimal decimalOutput;
                    var amount = Console.ReadLine();
                    bool isDecimal = decimal.TryParse(amount, out decimalOutput);
                    if (!isDecimal)
                    {
                        Console.WriteLine("To nije pravilan unos");
                    }
                    else
                    {
                        foreach (var asset in fungibleAssetList)
                        {
                            if (asset.Label == fLabel)
                            {
                                newWallet.AddBalanceOfFungibleAsset(asset.Adress, decimalOutput);
                            }
                        }
                    }
                }
                return newWallet;
            }


        }
    }
}