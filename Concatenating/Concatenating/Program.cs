using System;

namespace Concatenating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatenating App");

            Console.Write("Enter your lucky number: ");

            string luckyNumber = Console.ReadLine();

            Console.WriteLine("Your lucky number is: " + luckyNumber);

        }
    }
}
