namespace DistanceCalculatorRestService.Controllers
{
    using System;
    using System.Web.Http;

    public class PointsController : ApiController
    {
        public double Get(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }
    }
}
