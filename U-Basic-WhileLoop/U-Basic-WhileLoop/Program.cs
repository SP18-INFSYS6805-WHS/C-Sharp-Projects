using System;

namespace U_Basic_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Basic while Loop App!");
            Console.WriteLine("");
            Console.WriteLine("");

            int x = 0;
            while (x <= 10)
            {
                Console.WriteLine("The value of 'x' is: {0}", x);
                x++;
            }
            Console.WriteLine("While Loop Completed!");

            Console.WriteLine("");

            Console.WriteLine("Do-While Loop");
            int y = 10;
            do
            {
                Console.WriteLine("The value of 'y' is: {0}", y);
                y--;
            } while (y != 0);
            Console.WriteLine("Do-While Loop Completed!");

            Console.WriteLine("");

            Console.WriteLine("Another Do-While Loop");
            int z = 0;
            do
            {
                Console.WriteLine("The value of 'z' is: {0}", z);
                z++;
            } while (z <= 10);
            Console.WriteLine("2nd Do-While Loop Completed!");


            Console.WriteLine("");

            Console.WriteLine("One more Do-While Loop to show it will execute at least once");
            int a = 5;
            do
            {
                Console.WriteLine("The value of 'a' is: {0}", a);
                a++;
            } while (a > 20);
            Console.WriteLine("3rd Do-While Loop Completed!");

        }
    }
}
