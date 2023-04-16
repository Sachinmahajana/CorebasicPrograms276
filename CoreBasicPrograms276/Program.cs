namespace CoreBasicPrograms276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Corebasic Programs");
            Console.WriteLine("Please enter any one program");
            Console.WriteLine("1:EvenOdd\n2:Swapnumber\n3.Factornumber\n4:LargestNumber\n5:LeapYear\n6:Flipcoin");
            Console.WriteLine("7:Table2\n8:HarmonicNumber\n9:VowelOrConstant\n10:QutionDiv");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter the number");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Evenodd.FindEvenOdd(input);
                    break;
                case 2:
                    SwapNumber myObj = new SwapNumber();
                    myObj.FindSwapNumber();
                    break;
                case 3:
                    Console.WriteLine("Enter the number to find factor");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Factornumber.FactorFunction(n);
                    break;
                case 4:
                    LargeNumber.FindLargerNumber();
                    break;
                case 5:
                    LeapYear.FindLeapYear();
                    break;
                case 6:
                    FlipCoin myObj3 = new FlipCoin();
                    myObj3.FindFlipcoinPercentage();
                    break;
                case 7:
                    Table2 table = new Table2();
                    table.Power2Function();
                    break;
                case 8:
                    HarmonicNumber myObj5 = new HarmonicNumber();
                    myObj5.HarmonicNumber2();
                    break;
                case 9:
                    Vowelorconstant myObj6 = new Vowelorconstant();
                    myObj6.character();
                    break;
                case 10:
                    QuotionDiv myObj9 = new QuotionDiv();
                    myObj9.QuotionDivFun();
                    break;
                default:
                    Console.WriteLine("Please select program given below");
                    break;
            }
        }
    }
}