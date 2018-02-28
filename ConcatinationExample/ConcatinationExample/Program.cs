using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


namespace ConcatinationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n ***** Some examples of using StringBuilder. ****\n\n");


            var stringOne = "Hello, ";
            var stringTwo = "I love you ";
            var stringThree = "won't you tell me your name?";
            Console.WriteLine(stringOne + stringTwo + stringThree);


            // Now better to use 'StringBuilder' 

            var sb = new StringBuilder();
            sb.Append("It was the best of times, it was the worst of times ");
            sb.Append("it was the age of wisdom, ");
            sb.Append("it was the age of foolishness 1.");
            Console.WriteLine(sb.ToString());

            sb = new StringBuilder("It was the best of times, it was the worst of times, ");
            Console.WriteLine(sb.ToString());

            sb.AppendLine("it was the age of wisdom, ");
            sb.AppendLine("it was the age of foolishness 2.");
            Console.WriteLine("\n" + sb.ToString());

            sb = new StringBuilder();
            sb.Append("It was the best of times, it was the worst of times,\r\n");
            sb.Append("it was the age of wisdom,\r\n");
            sb.Append("it was the age of foolishness 3.");
            Console.WriteLine("\n" + sb.ToString());


            sb = new StringBuilder();
            sb.Append("It was the best of times, it was the worst of times, ");
            sb.Append("it was the age of wisdom, ");
            sb.Append("it was the age of foolishness 4.");
            Console.WriteLine("\n" + sb.ToString());
        }
    }
}
