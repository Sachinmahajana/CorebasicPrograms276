using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicPrograms276
{
    internal class LargeNumber
    {
        public static void FindLargerNumber()
        {
            int a = 10, b = 20, c = 10;

            if(a > b && a > c)
            {
                Console.WriteLine("a is a greater");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("b is greater");
            }
            else
            {
                Console.WriteLine("c is greater");
            }
        }
    }
}
