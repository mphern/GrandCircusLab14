using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAlligatorsCloningSheep
{
    class CountTestApp
    {
        public static void DisplayCount(Alligator alligator)
        {
            CountUtil.Count(alligator, 3);
        }

        public static void DisplayCount(Sheep sheep)
        {
            CountUtil.Count(sheep, 2);
            Console.Write("\n");
            sheep.ResetCount();
            Sheep cloneSheep = (Sheep) sheep.Clone();
            int count = Validator.ValidateInt("We will now clone the sheep! How many clones do you want to make: ");
            Console.Write("We've cloned the sheep! Pick a new name: ");
            string name = Console.ReadLine();
            Console.Write("\n");
            cloneSheep.Name = name;
            CountUtil.Count(cloneSheep, count);
            Console.Write("\n");
            CountUtil.Count(sheep, 1);
        }

    }
}
