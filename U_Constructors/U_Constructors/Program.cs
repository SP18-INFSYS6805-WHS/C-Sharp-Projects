using System;

namespace U_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructors App.");

            Console.WriteLine("");
            Console.WriteLine("");

            // instantiate the class
            Addition myAddition = new Addition();
            Console.WriteLine("The sum of my two numbers is {0}", myAddition.AddNumbers());

            Addition myAddition2 = new Addition(10, 20);
            Console.WriteLine("The sum of my two numbers is {0}", myAddition2.AddNumbers());

        }
    }
}
