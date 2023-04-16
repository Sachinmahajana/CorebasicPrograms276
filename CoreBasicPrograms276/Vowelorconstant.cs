using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicPrograms276
{
    internal class Vowelorconstant
    {
        public class VowelorConstant
        {
            public void character()
            {
                char ch;
                Console.WriteLine("Input Alphabet A-z or a-z");
                ch = Convert.ToChar(Console.ReadLine());
                int i = ch;
                if (i > 48 && i < 57)
                {
                    Console.WriteLine("You enter the Number ");
                }
                else
                {
                    switch (ch)
                    {
                        case 'a':
                            Console.WriteLine("The Alphabet is Vowel");
                            break;
                        case 'e':
                            Console.WriteLine("The Alphabet is Vowel");
                            break;
                        case 'i':
                            Console.WriteLine("The Alphabet is Vowel");
                            break;
                        case 'o':
                            Console.WriteLine("The Alphabet is Vowel");
                            break;
                        case 'u':
                            Console.WriteLine("The Alphabet is Vowel");
                            break;
                        default:
                            Console.WriteLine("the alphabet is consonant");
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}