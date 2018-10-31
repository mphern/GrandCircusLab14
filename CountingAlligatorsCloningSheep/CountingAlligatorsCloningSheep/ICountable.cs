using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAlligatorsCloningSheep
{
    interface ICountable
    {
        string Name { get; set; }

        void IncrementCount();

        void ResetCount();

        int GetCount();

        string GetCountString();
    }
}
