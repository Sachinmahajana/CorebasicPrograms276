using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicPrograms276
{
    internal class Table2
    {
        int i;
        public void Power2Function()
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
