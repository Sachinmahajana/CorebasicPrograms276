namespace CoreBasicPrograms276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Corebasic Programs");
            Console.WriteLine("Please enter any one program");
            Console.WriteLine("1:EvenOdd\n2:Swapnumber\n3.Factornumber");
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
            }
  
        }
    }
}