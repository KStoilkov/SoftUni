namespace _03.PC_Catalog
{
    using System;

    class PCCatalog
    {
        public static void Main()
        {
            //creating Components
            Component motherboard1 = new Component("Gigabyte AM3+", 205.50);
            Component motherboard2 = new Component("ASUS RAMPAGE V EXTREME", 560.65);
            Component ram1 = new Component("Apacer", "DDR3", 150.00);
            Component ram2 = new Component("Corsair", "DDR4", 449.99);
            Component hdd1 = new Component("Seagate", "1TB HDD", 250.50);
            Component hdd2 = new Component("Kingston", "256GB SSD", 450.70);
            Component cdrom = new Component("LG", 50.55);
            Component floppy = new Component("IdkAny", "old stuff", 5.50);

            //creating Computers
            Computer LG_PC = new Computer("LG", motherboard1, ram2, hdd2, cdrom);
            Computer MacPro = new Computer("Macbook Pro", motherboard2, ram2, hdd2, cdrom);
            Computer MacAir = new Computer("Macbook Air", motherboard1, ram1, hdd2);
            Computer Lenovo = new Computer("Lenovo", motherboard1, ram1, hdd1, cdrom);
            Computer Dell = new Computer("Dell", motherboard2, ram2, hdd1, cdrom, floppy);

            Computer[] Computers = { LG_PC, MacPro, MacAir, Lenovo, Dell };

            Array.Sort(Computers, (c1, c2) => c1.Price.CompareTo(c2.Price));

            foreach (var pc in Computers)
            {
                Console.WriteLine(pc);
            }
        }
    }
}
