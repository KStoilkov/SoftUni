namespace _03.PC_Catalog
{
    using System;
    using System.Text;

    class Computer
    {
        private string name;
        private Component motherboard;
        private Component ram;
        private Component hdd;
        private Component cdrom;
        private Component floppy;

        public Computer(string name, Component motherboard, Component ram, 
            Component hdd) 
            : this (name, motherboard, ram, hdd, null, null)
        {

        }

        public Computer(string name, Component motherboard, Component ram, 
            Component hdd, Component cdrom)
            : this(name, motherboard, ram, hdd, cdrom, null)
        {

        }

        public Computer(string name, Component motherboard, Component ram, 
            Component hdd, Component cdrom, Component floppy)
        {
            this.Name = name;
            this.Motherboard = motherboard;
            this.Ram = ram;
            this.Hdd = hdd;
            this.Cdrom = cdrom;
            this.Floppy = floppy;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.name = value; 
            }
        }

        public Component Motherboard { get; set; }

        public Component Ram { get; set; }

        public Component Hdd { get; set; }

        public Component Cdrom { get; set; }

        public Component Floppy { get; set; }

        public double Price 
        {
            get
            {
                if (this.cdrom == null && this.floppy == null)
                {
                    return this.Motherboard.Price + this.Ram.Price + 
                        this.Hdd.Price;
                }
                if (this.floppy == null)
                {
                    return this.Motherboard.Price + this.Ram.Price + 
                        this.Hdd.Price + this.Cdrom.Price;
                }
                return this.Motherboard.Price + this.Ram.Price +
                        this.Hdd.Price + this.Cdrom.Price + this.Floppy.Price;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Name + " " + this.Motherboard + " " + this.Ram + " ");

            if (this.Cdrom != null)
            {
                result.Append(this.Cdrom + " ");
            }
            if (this.Floppy != null)
            {
                result.Append(this.Floppy + " ");
            }
            result.Append("|| " + this.Price + "лв. ||");
            return result.ToString();
        }
    }
}
