using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAlligatorsCloningSheep
{
    class Alligator : ICountable
    {

        public int Count { private get; set; } = 1;

        public string Name { get; set; } = "alligator";


        public void IncrementCount()
        {
            Count++;
        }

        public void ResetCount()
        {
            Count = 1;
        }

        public int GetCount()
        {
            return Count;
        }

        public string GetCountString()
        {
            return Count.ToString();
        }
    }
}
