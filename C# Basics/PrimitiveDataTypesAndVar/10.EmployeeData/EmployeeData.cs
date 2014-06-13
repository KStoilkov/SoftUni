using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            // A marketing company wants to keep record of its employees. Each record would have the following characteristics:
            //    •	First name
            //    •	Last name
            //    •	Age (0...100)
            //    •	Gender (m or f)
            //    •	Personal ID number (e.g. 8306112507)
            //    •	Unique employee number (27560000…27569999)
            // Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.


            string firstName = "Goshko";
            string lastName = "Toshkov";
            byte age = 99;
            char gender = 'm';
            long PersonalIDNumber = 2244528642;
            ulong UniqueEmployeeNumber = 1234567890123456789;


            Console.WriteLine("Employer data: ");
            Console.WriteLine();
            Console.WriteLine("Name: {0}", firstName + " " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID Number: " + PersonalIDNumber);
            Console.WriteLine("Unique Employee Number: " + UniqueEmployeeNumber);
            Console.WriteLine();
        }
    }
}
