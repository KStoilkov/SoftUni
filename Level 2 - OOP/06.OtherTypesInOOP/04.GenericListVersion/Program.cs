namespace _04.GenericListVersion
{   
    using System;

    class Test
    {
        static void Main()
        {
            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in allAttributes)
            {
                Console.WriteLine("Version: " + attribute.Version);
            }
        }
    }
}