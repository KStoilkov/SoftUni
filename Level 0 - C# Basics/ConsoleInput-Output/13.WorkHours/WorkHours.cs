using System;

namespace _13.WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double productivity = (double)d * 10.00 / 100.00;
            double workHours = (double)(d) - productivity;
            workHours *= 12.00;
            double effectiveWork = workHours * (double)p / 100.00;
            int roundedEW = (int)Math.Abs(effectiveWork);
            int result = roundedEW - h;

            if (result >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(result);
            }
        }
    }
}
