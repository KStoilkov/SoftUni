namespace _06.Namespaces
{
    using _06.Namespaces.Geometry.Geometry2D;
    using _06.Namespaces.Geometry.Geomtery3D;
    using _06.Namespaces.Geometry.Storage;
    using _06.Namespaces.Geometry.UI;
    
    class Test
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Path3D path = new Path3D();

            GeometryBinaryStorage gbs = new GeometryBinaryStorage();

            Screen2D screen = new Screen2D();
            Screen3D screen1 = new Screen3D();
        }
    }
}
