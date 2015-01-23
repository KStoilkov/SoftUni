namespace _02.Laptops
{
    using System;

    class LaptopShop
    {
        public static void Main()
        {
            Laptop Acer = new Laptop("Acer", 1201.98);
            Console.WriteLine(Acer);
            Laptop Lenovo = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "IntelCore i5-4210U",
                8, "IntelHD Graphics4400", "128GB SSD", "13.3(33.78 cm) IPS sensor display",
                "Li-lon,4-cells, 2550 mAh", 4.5, 2259.00);
            Console.WriteLine(Lenovo);
        }
    }
}
