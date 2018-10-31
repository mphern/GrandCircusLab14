using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAlligatorsCloningSheep
{
    class CountUtil
    {
        public static void Count(ICountable c, int MaxCount)
        {
            while (c.GetCount() <= MaxCount)
                {
                    Console.WriteLine(c.GetCountString() + " " + c.Name);
                    c.IncrementCount();
                }

        }
    }
}
