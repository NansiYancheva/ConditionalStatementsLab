﻿using System;
namespace Number100200
{
    class Program
    {
        static void Main()
        {
            //Input
            int number = int.Parse(Console.ReadLine());
            //Action
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }    
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
            //Output
        }
    }
}
