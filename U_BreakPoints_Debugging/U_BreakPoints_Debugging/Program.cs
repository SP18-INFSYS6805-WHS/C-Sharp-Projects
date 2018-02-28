using System;

namespace U_Basic_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Basic Arrays App.");
            Console.WriteLine("");

            int[] numbers = new int[6];

            numbers[0] = 200;
            numbers[1] = 100;
            numbers[2] = 700;
            numbers[3] = 440;
            numbers[4] = 220;
            numbers[5] = 990;
            // numbers[6] = 110; // just to test error exception


            Console.WriteLine("The value at numbers index 2 is: " + numbers[2]);

            Console.WriteLine("");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("The value at numbers index {0} is: " + numbers[i], i);
            }

            Console.WriteLine("");


            Console.WriteLine("Another way to initialize and set and array");

            int[] numbers2 = { 55, 222, 578778, 234, 654, 9, 27 };

            Console.WriteLine("");

            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine("The value at numbers2 index {0} is: " + numbers2[i], i);
            }
            Console.WriteLine("");

            for (int i = numbers2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("The value at numbers2 index {0} is: " + numbers2[i], i);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "December" };

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            Console.WriteLine("");
            Console.WriteLine("");

            string myString = "I kinda like codding!";
            char[] myChar = myString.ToCharArray();
            Console.WriteLine(myChar);

            Array.Reverse(myChar);
            Console.WriteLine(myChar);



        }
    }
}
