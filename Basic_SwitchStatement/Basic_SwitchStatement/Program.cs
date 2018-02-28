using System;

namespace Basic_SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Switch Statement App.");

            Console.WriteLine("Choose a number: 1, 2, or 3?");
            string userInput = Console.ReadLine();

            string message;

            switch (userInput)
            {
                case "1":
                    message = "You won a new car!";
                    break;
                case "2":
                    message = "You won a new bike!";
                    break;
                case "3":
                    message = "You won a trip!";
                    break;
                default:
                    message = "Invalid input! You can't win that way!";
                    break;
            }

            Console.WriteLine(message);

        }
    }
}
