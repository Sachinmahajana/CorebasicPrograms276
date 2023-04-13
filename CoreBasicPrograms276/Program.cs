namespace CoreBasicPrograms276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Corebasic Programs");
            Console.WriteLine("Please enter the number");
            int input = Convert.ToInt32(Console.ReadLine());
            Evenodd.FindEvenOdd(input);
           
        }
    }
}