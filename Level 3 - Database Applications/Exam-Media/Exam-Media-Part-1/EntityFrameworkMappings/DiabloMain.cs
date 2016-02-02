using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMappings
{
    public class DiabloMain
    {
        static void Main()
        {
            var context = new DiabloContext();
            var charactersNames = context.Characters.Select(c => c.Name);

            foreach (var name in charactersNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
