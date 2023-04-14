using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicPrograms276
{
    internal class Factornumber
    {
        public static void FactorFunction(int number)
        {
            int function = 1;
            int input = number;

            for (int i = number; i > 0; i--)
            {
                function = function * i;
            }
            Console.WriteLine("Factorial of {0} is {1}:", input,function);
        }
    }
}
