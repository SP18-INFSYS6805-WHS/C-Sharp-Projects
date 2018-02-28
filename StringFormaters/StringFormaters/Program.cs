using System;

namespace StringFormaters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n****   String Formaters  String.Format method ****");


            var city = "Saint Louis, MO";
            var temp = 20.5f;
            var currentDt = DateTime.Now;
            string.Format("Welcome to {0}. The date and time is {1}. The temperature is {2}f.", city, currentDt, temp);

            Console.WriteLine(string.Format("Welcome to {0}. \nThe date and time is {1}. \nThe temperature is {2}f.", city, currentDt, temp));

            // that was good but let's work on formating better below
            Console.WriteLine("\n\nNow with formating the time\n");

            // for the time the 1:t means 'short' time format so it will just display the time
            Console.WriteLine(string.Format("Welcome to {0}. \nThe time is {1:t}. \nThe temperature is {2}f.", city, currentDt, temp));

            // for the time the 1:T means 'long' time format so it will just display the time
            Console.WriteLine(string.Format("\nWelcome to {0}. \nThe time is {1:T}. \nThe temperature is {2}f.", city, currentDt, temp));

            Console.WriteLine("\n\nNow with formating the temperature\n");

            // for the time the 2:0.00 means adding decimal places to the temp
            Console.WriteLine(string.Format("Welcome to {0}. \nThe time is {1:t}. \nThe temperature is {2:0.00}f.", city, currentDt, temp));

            temp = 2040.5f;
            // for the time the 2:0,0.00 means adding decimal and comma to thousands places to the temp
            Console.WriteLine(string.Format("\nWelcome to {0}. \nThe time is {1:T}. \nThe temperature is {2:0,0.00}f.", city, currentDt, temp));




        }
    }
}
