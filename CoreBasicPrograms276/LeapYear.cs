using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicPrograms276
{
    internal class LeapYear
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 400 == 0 )
            {
                Console.WriteLine("{0} is a leap year",year);
            }
            else if(year % 100 == 0)
            {
                Console.WriteLine("{0} is not a lep year", year);
            }
            else if(year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year");
            }
          
           
        }
    }
}
