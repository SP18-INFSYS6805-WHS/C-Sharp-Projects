using System;

namespace Substitution_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Substitution Strings App");

            Console.Write("What is your favorite food? ");
            string favFood = Console.ReadLine();

            Console.Write("What is your favorite color? ");
            string favColor = Console.ReadLine();

            Console.WriteLine("You like {0} and your favorite color is {1}. I also like {0}!", favFood, favColor);

            Console.Write("What is your lucky number? ");
            string luckyNum = Console.ReadLine();

            Console.WriteLine("Your lucky number is {0}.", luckyNum);

        }
    }
}



