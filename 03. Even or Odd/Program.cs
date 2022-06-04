using System;
namespace EvenOrOdd
{
    class Program
    {
        static void Main()
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            //Action
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            //Output
        }
    }
}
