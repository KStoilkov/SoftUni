namespace CalculatorConsoleClient
{
    using DistanceCalculatorService;
    using System;

    public class DistanceCalculatorMain
    {
        static void Main()
        {
            DistanceCalculatorClient dcc = new DistanceCalculatorClient();

            double distance = dcc.CalcDistance(10, 10, 15, 15);
            Console.WriteLine(distance);
        }
    }
}
