using CryptoWalletApp.Classes.Asset;
using CryptoWalletApp.Classes.Transaction;
using CryptoWalletApp.Classes.Wallet;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            //10 fungible assets
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

            //20 Non Fungible assets
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

            //9 wallets - po 3 btc, eth, sol
            //bitcoin wallets

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

            //ethereum wallets

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

            //solana wallets

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

            var listOfWallets = new List<Wallet>() 
            {
                bitcoinWallet1, bitcoinWallet2, bitcoinWallet3, ethereumWallet1, ethereumWallet2, ethereumWallet3,
                solanaWallet1, solanaWallet2, solanaWallet3
            };

            var listOfAbleToInteractiWithNonFungibleAssetsWallets = new List<AbleToInteractWithNonFungibleAssetWallet>()
            {
                ethereumWallet1, ethereumWallet2, ethereumWallet3,
                solanaWallet1, solanaWallet2, solanaWallet3
            };
                        
            var listOfFungibleAssetTransactions = new List<FungibleAssetTransaction>();
            var listOfNonFungibleAssetTransactions = new List<NonFungibleAssetTransaction>(); 
            var listOfTransactions = new List<Transaction>();

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
                        Console.WriteLine(listOfFungibleAssetTransactions.Count());
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
                            listOfWallets.Add(newBitcoinWallet);
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
                            listOfWallets.Add(newEthereumWallet);
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
                            listOfWallets.Add(newSolanaWallet);
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
                    item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                    item.UpdateHistoryOfValues();
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                foreach (var item in listOfEthereumWallets)
                {
                    item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                    item.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);
                    item.UpdateHistoryOfValues();
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
                foreach (var item in listOfSolanaWallets)
                {
                    item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                    item.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);
                    item.UpdateHistoryOfValues();
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
                    return;
                }
                
                var choiceOfSubmenu = "";
                while (choiceOfSubmenu != "0")
                {
                    Console.WriteLine("Submenu:\n1 - Portfolio\n2 - Transfer\n3 - Povijest transakcija\n0 - Povratak na inicijalni menu");
                    choiceOfSubmenu= Console.ReadLine();
                    switch (choiceOfSubmenu)
                    {
                        case "1":
                            Console.WriteLine("Odabrali ste 1 - Portfolio");
                            Portfolio(guidOutput);
                            break;
                        case "2":
                            Console.WriteLine("Odabrali ste 2 - Transfer");
                            Transfer(guidOutput);
                            break;
                        case "3":
                            Console.WriteLine("Odabrali ste 3 - Povijest transakcija");
                            HistoryOfTransactions(listOfTransactions, guidOutput);
                            break;
                        default:
                            break;
                    }
                }
                
            }

            void HistoryOfTransactions(List<Transaction> fListOfTransactions, Guid fGuidOutput)
            {
                List<Transaction> sortedListOfTransactions = fListOfTransactions.OrderByDescending(o => o.DateOfTransaction).ToList();
                foreach (var transaction in sortedListOfTransactions)
                {
                    if (transaction.AdressOfDonor == fGuidOutput)
                    {
                        Console.WriteLine(transaction);
                    }
                }

                Console.WriteLine("Ukoliko zelite opozvati neku transakciju unesite 1");
                var didRevoke = Console.ReadLine();
                if (didRevoke != "1")
                {
                    return;
                }
                RevokeTransaction(fGuidOutput);
            }

            void RevokeTransaction(Guid fGuidOutput)
            {
                Console.WriteLine("Unesite id transakcije koju zelite opozvati");
                Guid guidOutputTransaction;
                var adressOfTransaction = Console.ReadLine();
                bool isGuid = Guid.TryParse(adressOfTransaction, out guidOutputTransaction);
                DateTime now = DateTime.Now;

                if (!isGuid)
                {
                    Console.WriteLine("Neispravan unos adrese transakcije");
                    return;
                }
                foreach (var transaction in listOfTransactions)
                {
                    if (transaction is FungibleAssetTransaction && guidOutputTransaction == transaction.Id)
                    {
                        if (now.Subtract(transaction.DateOfTransaction).TotalSeconds > 45)
                        {
                            Console.WriteLine("Ne moze se opozvati jer je proslo vise od 45 sekundi od izvrsenja");
                            return;
                        }

                        transaction.WasRevoked = true;
                        foreach (var walletDonor in listOfWallets)
                        {
                            foreach (var walletReceiver in listOfWallets)
                            {
                                if (walletDonor.Adress == transaction.AdressOfDonor && walletReceiver.Adress == transaction.AdressOfReceiver)
                                {
                                    walletDonor.AddBalanceOfFungibleAsset(transaction.AdressOfAsset, ((FungibleAssetTransaction)transaction).AmountOfFungibleAsset);
                                    walletReceiver.AddBalanceOfFungibleAsset(transaction.AdressOfAsset, -((FungibleAssetTransaction)transaction).AmountOfFungibleAsset);
                                }
                            }
                        }
                    }
                    else if(transaction is NonFungibleAssetTransaction && guidOutputTransaction == transaction.Id)
                    {
                        if (now.Subtract(transaction.DateOfTransaction).TotalSeconds > 45)
                        {
                            Console.WriteLine("Ne moze se opozvati jer je proslo vise od 45 sekundi od izvrsenja");
                            return;
                        }

                        transaction.WasRevoked = true;
                        foreach (var walletDonor in listOfWallets)
                        {
                            foreach (var walletReceiver in listOfWallets)
                            {
                                if (walletDonor.Adress == transaction.AdressOfDonor && walletReceiver.Adress == transaction.AdressOfReceiver)
                                {
                                    AbleToInteractWithNonFungibleAssetWallet walletDonorTemp = walletDonor as AbleToInteractWithNonFungibleAssetWallet;
                                    AbleToInteractWithNonFungibleAssetWallet walletReceiverTemp = walletReceiver as AbleToInteractWithNonFungibleAssetWallet;
                                    if (walletDonorTemp != null && walletReceiverTemp != null)
                                    {
                                        walletDonorTemp.AddNonFungibleAsset(transaction.AdressOfAsset);
                                        walletReceiverTemp.RemoveNonFungibleAsset(transaction.AdressOfAsset);

                                    }
                                }
                            }

                        }
                    }
                }
            }

            void Transfer(Guid fGuidOutput)
            {
                Console.WriteLine("Unesite adresu walleta koji prima asset");
                Guid guidOutputReceiver;
                var adressOfReceiverWallet = Console.ReadLine();
                bool isGuidReceiver = Guid.TryParse(adressOfReceiverWallet, out guidOutputReceiver);

                Console.WriteLine("Unesite adresu asseta koji se salje");
                Guid guidOutputAsset;
                var adressOfAsset = Console.ReadLine();
                bool isGuidAsset = Guid.TryParse(adressOfAsset, out guidOutputAsset);

                if (!(isGuidAsset && isGuidReceiver))
                {
                    Console.WriteLine("Niste ispravno unijeli adrese");
                    return;
                }
                var isFungible = false;
                var isNonFungible = false;
                foreach (var item in fungibleAssetList)
                {
                    if (guidOutputAsset == item.Adress)
                    {
                        isFungible = true;
                    }
                }

                foreach (var item in nonFungibleAssetList)
                {
                    if (guidOutputAsset == item.Adress)
                    {
                        isNonFungible = true;
                    }
                }
                if (isFungible)
                {
                    Console.WriteLine("Unesite kolicinu asseta (jer je asset fungible): ");
                    decimal decimalOutput;
                    var amountOfFungibleAssetInuput = Console.ReadLine();
                    bool isAmountDecimal = decimal.TryParse(amountOfFungibleAssetInuput, out decimalOutput);

                    if (!isAmountDecimal)
                    {
                        Console.WriteLine("Niste ispravno uniijeli količinu");
                        return;
                    }
                    if (decimalOutput <= 0)
                    {
                        Console.WriteLine("Količina koju se šalje ne može biti ne-pozitivna");
                        return;
                    }
                    CreateFungibleAssetTransaction(fGuidOutput, guidOutputAsset, guidOutputReceiver, decimalOutput);                  
                }
                else if (isNonFungible)
                {
                    CreateNonFungibleAssetTransaction(fGuidOutput, guidOutputAsset, guidOutputReceiver);
                }
                else
                    Console.WriteLine("Unesena adresa asseta ne pripada nijednom assetu");

                Console.WriteLine($"Broj fungible asset transakcija: {listOfFungibleAssetTransactions.Count()}");
                Console.WriteLine($"Broj non fungible asset transakcija: {listOfNonFungibleAssetTransactions.Count()}");
            }

            void CreateFungibleAssetTransaction(Guid fGuidOutput, Guid fGuidOutputAsset, Guid fGuidOutputReceiver, decimal fDecimalOutput)
            {
                foreach (var walletDonor in listOfWallets)
                {
                    if (walletDonor.Adress == fGuidOutput)
                    {
                        if (!walletDonor.BalancesOfFungibleAsset.ContainsKey(fGuidOutputAsset))
                        {
                            Console.WriteLine("Wallet koji bi trebao poslati asset ga uopce ne posjeduje");
                            return;                            
                        }

                        if (!(walletDonor.BalancesOfFungibleAsset[fGuidOutputAsset] >= fDecimalOutput))
                        {
                            Console.WriteLine("Wallet donor nema dovoljnu kolicinu asseta");
                            return;
                        }
                        foreach (var walletReceiver in listOfWallets)
                        {
                            if (walletReceiver.AdressesOfSupportedFungibleAssets.Contains(fGuidOutputAsset) && walletReceiver.Adress == fGuidOutputReceiver)
                            {
                                Console.WriteLine("Ako zelite potvrditi transfer upisite DA");
                                var confirmationOfTransfer = Console.ReadLine();
                                if (!(confirmationOfTransfer == "DA"))
                                {
                                    Console.WriteLine("Transfer ponisten");
                                    return;
                                }
                                walletDonor.AddBalanceOfFungibleAsset(fGuidOutputAsset, -fDecimalOutput);
                                walletReceiver.AddBalanceOfFungibleAsset(fGuidOutputAsset, fDecimalOutput);

                                foreach (var asset in fungibleAssetList)
                                {
                                    if (asset.Adress == fGuidOutputAsset)
                                    {
                                        asset.ChangeValueOfFungibleAssetRandomly();
                                    }
                                }

                                var newFungibleAssetTransaction = new FungibleAssetTransaction(fGuidOutputAsset, fGuidOutput, fGuidOutputReceiver)
                                {
                                    StartBalanceOfDonor = walletDonor.HistoryOfValuesInUSD[walletDonor.HistoryOfValuesInUSD.Count() - 2],
                                    EndBalanceOfDonor = walletDonor.HistoryOfValuesInUSD[walletDonor.HistoryOfValuesInUSD.Count() - 1],
                                    StartBalanceOfReceiver = walletReceiver.HistoryOfValuesInUSD[walletReceiver.HistoryOfValuesInUSD.Count() - 2],
                                    EndBalanceOfReceiver = walletReceiver.HistoryOfValuesInUSD[walletReceiver.HistoryOfValuesInUSD.Count() - 1],
                                    AmountOfFungibleAsset = fDecimalOutput
                                };

                                newFungibleAssetTransaction.GetFungibleAssetName(fungibleAssetList);

                                listOfFungibleAssetTransactions.Add(newFungibleAssetTransaction);
                                listOfTransactions.Add(newFungibleAssetTransaction);
                            }
                            else if (walletReceiver.Adress == fGuidOutputReceiver)
                                Console.WriteLine("Wallet koji treba primiti asset ga ne podrzava");
                        }
                    }
                }
            }

            void CreateNonFungibleAssetTransaction(Guid fGuidOutput, Guid fGuidOutputAsset, Guid fGuidOutputReceiver)
            {
                if (!((listOfAbleToInteractiWithNonFungibleAssetsWallets.FindAll(element => element.Adress == fGuidOutput).Count() > 0) && (listOfAbleToInteractiWithNonFungibleAssetsWallets.FindAll(element => element.Adress == fGuidOutputReceiver).Count() > 0)))
                {
                    Console.WriteLine("Nisu oba unesena walleta sposobna interaktati s non fungible assetima");
                    return;
                }
                foreach (var walletDonor in listOfAbleToInteractiWithNonFungibleAssetsWallets)
                {
                    if (walletDonor.Adress == fGuidOutput && walletDonor.AdressesOfOwnedNonFungibleAssets.Contains(fGuidOutputAsset))
                    {
                        foreach (var walletReceiver in listOfAbleToInteractiWithNonFungibleAssetsWallets)
                        {
                            if (walletReceiver.Adress == fGuidOutputReceiver && walletReceiver.AdressesOfSupportedNonFungibleAssets.Contains(fGuidOutputAsset))
                            {
                                Console.WriteLine("Ako zelite potvrditi transfer upisite DA");
                                var transferConfirmation = Console.ReadLine();
                                if (!(transferConfirmation == "DA"))
                                {
                                    Console.WriteLine("Transfer ponisten");
                                    return;
                                }
                                
                                walletDonor.RemoveNonFungibleAsset(fGuidOutputAsset);
                                walletReceiver.AddNonFungibleAsset(fGuidOutputAsset);

                                foreach (var nonFungibleAsset in nonFungibleAssetList)
                                {
                                    if (nonFungibleAsset.Adress == fGuidOutputAsset)
                                    {
                                        foreach (var fungibleAsset in fungibleAssetList)
                                        {
                                            if (fungibleAsset.Adress == nonFungibleAsset.AdressOfSpecificFungibleAsset)
                                            {
                                                fungibleAsset.ChangeValueOfFungibleAssetRandomly();
                                            }
                                        }
                                    }
                                }

                                foreach (var asset in fungibleAssetList)
                                {
                                    if (asset.Adress == fGuidOutputAsset)
                                    {
                                        asset.ChangeValueOfFungibleAssetRandomly();
                                    }
                                }

                                var newNonFungibleAssetTransaction = new NonFungibleAssetTransaction(fGuidOutputAsset, fGuidOutput, fGuidOutputReceiver) { };
                                newNonFungibleAssetTransaction.GetNonFungibleAssetName(nonFungibleAssetList);
                                listOfNonFungibleAssetTransactions.Add(newNonFungibleAssetTransaction);
                                listOfTransactions.Add(newNonFungibleAssetTransaction);
                            }
                            else if (walletReceiver.Adress == fGuidOutputReceiver)
                            {
                                Console.WriteLine("Wallet koji treba primiti asset ga uopce ne podrzava");
                            }
                        }
                    }
                    else if (walletDonor.Adress == fGuidOutput)
                        Console.WriteLine("Wallet donor nema taj non fungible asset");
                }

            }

            void Portfolio(Guid fGuidOutput)
            {
                foreach (var item in listOfBitcoinWallets)  
                {
                    item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                    item.UpdateHistoryOfValues();
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

                foreach (var item in listOfEthereumWallets)  
                {
                    item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                    item.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);
                    item.UpdateHistoryOfValues();
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

                foreach (var item in listOfSolanaWallets)  
                {
                    item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                    item.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);
                    item.UpdateHistoryOfValues();
                    if (fGuidOutput == item.Adress)
                    {
                        item.CalculateTotalValueOfFungibleAssetsInUSD(fungibleAssetList);
                        item.CalculateTotalValueOfNonFungibleAssetsInUSD(nonFungibleAssetList, fungibleAssetList);
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
                    Console.WriteLine($"Fungible asset s labelom {fLabel} nije podrzan u walletu");
                }
                else
                {
                    Console.WriteLine($"Unesite koliko {fLabel} zelite postaviti ");
                    decimal decimalOutput;
                    var amount = Console.ReadLine();
                    bool isDecimal = decimal.TryParse(amount, out decimalOutput);
                    if (!isDecimal || decimalOutput < 0)
                    {
                        Console.WriteLine("To nije pravilan unos (ako potvrdite stvaranje walleta kolicina ovog asseta ce biti 0)");
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