using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FirstEssentialTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tester = 20;
            //changed
            var longerString = "Hello my pretty, I would love to have you for diner";
            Console.WriteLine(longerString.Substring(9,tester));

            double myNum = 4.6728377;

            Console.WriteLine(Math.Round(myNum));

            string testString = " asdfHGGEjj  ";
            Console.WriteLine(testString);

            string finalString = testString.Trim();
            Console.WriteLine(finalString);

            Console.WriteLine(finalString.ToUpper());
            Console.WriteLine(finalString.ToLower());

            var endT = finalString.Length;
            Console.WriteLine(endT);

            int startIndex = 24;


            // *** the first section adds a space in the begining of final product
            //string challenge = " Text processing in C# is really great!  ";
            //Console.WriteLine(challenge + "Before trim");

            //challenge = challenge.Trim();
            //Console.WriteLine(challenge + "\tAfter trim");

            //int testL = challenge.Length;
            //Console.WriteLine(testL + "\tString length");
            //int finalIndex = testL - startIndex;
            //Console.WriteLine("String length of: " + testL + " minus the starting index of: " + startIndex + " equals the final index of: " + finalIndex);

            //Console.WriteLine(challenge.ToUpper().Substring(startIndex,finalIndex));

            // or another more compact way

            string string2 = " Text processing in C# is really great!  ";
            Console.WriteLine(string2.Trim().Substring(24, string2.Trim().Length - 24).ToUpper().Trim());
            //or
            string result = string2.Trim().Substring(24, string2.Trim().Length - 24).ToUpper().Trim();
            Console.WriteLine(result);




        }

    }
}
