using System;
namespace ExcellentResult
{
    class Program
    {
        static void Main()
        {
            //Input
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            //Action
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
            //Output
        }
    }
}

