using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 25; i++)
            //{
            //    Console.WriteLine($"The square of {i} is {Math.Pow(i, 2)}");
            //}


            // create a multiplication Table


            /*
             * 1    2    3    4    5    6    7    8   9   10   11   12
             * 2    4    6    8    10   12   14   16  18  20   22   24
             * 3....
             */

            for (int r = 1; r <= 12; r++)
            {
                string tableRow = "";

                for (int c = 1; c <= 12; c++)
                {
                    int product = r * c;
                    string productString = product.ToString() + "\t";
                    tableRow += productString;

                }
                Console.WriteLine(tableRow);

            }
        }
    }
}
