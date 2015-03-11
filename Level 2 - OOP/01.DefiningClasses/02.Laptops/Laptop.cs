namespace _02.Laptops
{
    using System;
    using System.Text;

    class Laptop
    {
        private string model;
        private double price;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;

        public Laptop(string model, double price)
            : this(model, null, null, 0, null, null, null, null, 0, price)
        {
        }

        public Laptop(string model, string manufacturer, 
            string processor, int ram, string graphicCard,
            string hdd, string screen, string batteryType, double batteryLife, double price) 
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;

            if (batteryType == null && batteryLife == 0)
            {
                this.Battery = null;
            }
            else
            {
                this.Battery = new Battery(batteryType, batteryLife);
            }

            this.Price = price;
        }

        public string Model 
        { 
            get
            {
                return this.model;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                this.model = value;
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

        public string Manufacturer 
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("Manufacturer cannot be empty.");
                }
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("Processor canot be empty");                    
                }
                this.processor = value;
            }
        }

        public int Ram 
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("RAM cannot be less than 0");
                }
                this.ram = value;
            }
        }

        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("Graphic Card cannot be empty");
                }
                this.graphicCard = value;
            }
        }

        public string Hdd 
        { 
            get
            {
                return this.hdd;   
            }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("HDD cannot be empty");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value == "")
                {
                    throw new ArgumentException("Screen cannot be empty");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        { 
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Model: " + this.Model);
            if (this.Manufacturer != null)
            {
                output.AppendLine("Manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                output.AppendLine("Processor: " + this.Processor);
            }
            if (this.Ram != 0)
            {
                output.AppendLine("RAM: " + this.Ram + "GB");
            }
            if (this.GraphicCard != null)
            {
                output.AppendLine("Graphic Card: " + this.GraphicCard);
            }
            if (this.Hdd != null)
            {
                output.AppendLine("HDD: " + this.Hdd);
            }
            if (this.Screen != null)
            {
                output.AppendLine("Screen: " + this.Screen);
            }
            if (this.Battery != null)
            {
                output.AppendLine(this.Battery.ToString());
            }
            output.AppendLine("Price: " + this.Price);
            return output.ToString();
        }
    }
}
