using System;
namespace PasswordGuess
{
    class Program
    {
        static void Main()
        {
            //Input
            string password = Console.ReadLine();
            //Action
            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
            //Output
        }
    }
}
