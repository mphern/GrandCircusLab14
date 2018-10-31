using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAlligatorsCloningSheep
{
    class Program
    {
        static void Main()
        {
            Alligator alligator = new Alligator();
            Sheep sheep = new Sheep();
            Console.WriteLine("Counting Alligators...\n");
            CountTestApp.DisplayCount(alligator);
            Console.Write("\n");
            Console.WriteLine("Counting Sheep...\n");
            CountTestApp.DisplayCount(sheep);
            Console.ReadKey();
        }
    }
}
