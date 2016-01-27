namespace DistanceCalculatorRestClient
{
    using System;
    using System.IO;
    using System.Net;

    public class DistanceCalculatorMain
    {
        static void Main()
        {
            string url = "http://localhost:59860/api/points?x1=10&y1=10&x2=15&y2=15";

            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd();

                Console.WriteLine(result);
            }
        }
    }
}
