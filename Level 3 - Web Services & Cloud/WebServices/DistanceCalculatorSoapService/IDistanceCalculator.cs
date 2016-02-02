namespace DistanceCalculatorSoapService
{
    using System.ServiceModel;

    [ServiceContract]
    public interface IDistanceCalculator
    {
        [OperationContract]
        double CalcDistance(int x1, int y1, int x2, int y2);
    }
}
