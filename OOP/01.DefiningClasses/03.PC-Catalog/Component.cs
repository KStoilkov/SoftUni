namespace _03.PC_Catalog
{
    using System;
    using System.Text;

    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string name, double price) : this(name, null, price)
        {
        }

        public Component(string name, string details, double price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public string Details 
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("Details cannot be empty.");
                }
                this.details = value;
            }
        }

        public double Price 
        {
            get
            {
                return this.price;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than 0.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Name + " ");

            if (this.Details != null)
            {
                result.Append(this.Details + " ");                
            }

            return result.ToString();
        }
    }
}
