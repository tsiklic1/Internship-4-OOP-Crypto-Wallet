namespace CryptoWalletApp.Classes.Asset
{
    public abstract class Asset
    {
        
        public Guid Adress { get;}
        public string Name { get; set; }

        public Asset()
        {
            Adress = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"Adresa: {Adress}\nIme: {Name}";
        }


    }
}
