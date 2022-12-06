namespace CryptoWalletApp.Classes.Asset
{
    public abstract class Asset
    {
        //public Guid id = new Guid("5C60F693-BEF5-E011-A485-80EE7300C695"); //static readonly
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
