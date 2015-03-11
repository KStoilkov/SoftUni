namespace _02.BankOfKurtovoKonare
{
    public abstract class Customer
    {
        public string Name { get; set; }

        protected Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "Customer Name: " + this.Name;
        }
    }
}
