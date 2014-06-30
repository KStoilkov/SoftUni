using System;

namespace _02.PrintCompanyInformation
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            // A company has name, address, phone number, fax number, web site and manager. 
            // The manager has first name, last name, age and a phone number. Write a program that reads the information
            // about a company and its manager and prints it back on the console.

            Console.Write("Company Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company Adress: ");
            string companyAdress = Console.ReadLine();
            Console.Write("Company Phone Number: ");
            uint phoneNumber = uint.Parse(Console.ReadLine());
            Console.Write("Company Fax Number: ");
            int faxNumber = int.Parse(Console.ReadLine());
            Console.Write("Company Website: ");
            string website = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte managerAge = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone number: ");
            uint managerPhoneNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Adress: " + companyAdress);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Fax: " + faxNumber);
            Console.WriteLine("Website: " + website);
            Console.WriteLine("Manager: " + firstName + " " + lastName + " ( age: " + managerAge + ", tel. " + managerPhoneNumber + ")" );
            Console.WriteLine();
        }
    }
}
