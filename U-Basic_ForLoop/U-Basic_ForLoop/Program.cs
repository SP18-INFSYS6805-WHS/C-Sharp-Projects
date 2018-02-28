using System;

namespace U_Basic_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Basic For Loop App.");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);

                if (i == 5)
                {
                    Console.WriteLine("High Five!");
                    //break;
                }
            }

            Console.WriteLine("Loop Completed!");

        }
    }
}
