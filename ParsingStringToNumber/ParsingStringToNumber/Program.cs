using System;

namespace ParsingStringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n  *** Parsing Strings into numbers ***\n");


            int num = int.Parse("15");

            Console.WriteLine(int.Parse("15") );
            Console.WriteLine(num);

            ////this is not going to work
            //int num = int.Parse("15,234");
            //Console.WriteLine(int.Parse("15,234"));
            //Console.WriteLine(num);

            // removing the comma from the number
            var test = "15,234";
            Console.WriteLine(int.Parse(test.Replace(",", "")));

            Console.WriteLine("\n\n  *** tryParse Strings into numbers ***\n");


            int result;
            //int.TryParse("15,234", out result);
            Console.WriteLine(int.TryParse("15,234", out result));
            //should fail and print false on the screen

            //this one works and prints true on the screen
            int.TryParse("15234", out result);
            Console.WriteLine(result);
            // but how can we use the numbers?

            string result1 = "15,234";
            int result2;
            if(int.TryParse(result1, out result2))
            {
                Console.WriteLine(result2);
            }
            else {
                Console.WriteLine("String could not be parsed.");
            }
                




        }
    }
}
