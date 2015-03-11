using System;

namespace _09.Int_double_string
{
    class IntDoubleString
    {
        static void Main()
        {
            // Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
            // If the variable is int or double, the program increases it by one. If the variable is a string, 
            // the program appends "*" at the end. Print the result at the console. Use switch statement. 

            start:
            Console.WriteLine("1--> Int");
            Console.WriteLine("2--> Double");
            Console.WriteLine("3--> String");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1: 
                    { 
                        Console.Write("Enter Integer: ");
                        int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine("result: " + (integer + 1));
                    };
                break;
                case 2:
                    {
                        Console.Write("Enter Double:");
                        double dbl = double.Parse(Console.ReadLine());
                        Console.WriteLine("result: " + (dbl + 1.00));
                    }
                break;
                case 3: 
                    {
                        Console.Write("Enter String: ");
                        string str = Console.ReadLine();
                        Console.WriteLine("result: " + str + "*");
                    }
                break;
                default: goto start;
                
            }
        }
    }
}
