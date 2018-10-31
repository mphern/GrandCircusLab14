using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAlligatorsCloningSheep
{
    class Validator
    {
        public static int ValidateInt(string message)
        {
            Console.Write(message);
            int num;
            while(!int.TryParse(Console.ReadLine(), out num) || num < 1)
            {
                Console.Write("Invalid selection. " + message);
            }
            return num;
        }
    }
}
