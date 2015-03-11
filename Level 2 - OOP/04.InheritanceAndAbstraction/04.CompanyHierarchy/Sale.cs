namespace _04.CompanyHierarchy
{
    using System;
    using Interfaces;

    public class Sale : ISale
    {
        private string productName;
        private double price;

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name cannot be empty.");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("");
                }
                this.price = value;
            }
        }

        public Sale(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("Product name: {0}, Start date: {1}, Price: {2}",
                this.ProductName, this.Date.ToString("dd-MM-yyyy"), this.Price);
        }
    }
}
