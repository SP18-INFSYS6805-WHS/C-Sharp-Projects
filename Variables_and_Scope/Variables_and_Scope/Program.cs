using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Variables_and_Scope
{
    class MainClass
    {
        // the score variable for the game
        public static int outsideValue = 5;

        public static void Main(string[] args)
        {

            // output vasiable to console
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
           // Console.WriteLine($"From outside: functionValue = {functionValue}");

            MyFunction();
            MyOtherFunction();

        }

        public static void MyFunction()
        {
            // Creating a variable inside of a function
            int functionValue = 10;

            // output vasiable to console
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
            Console.WriteLine($"From outside: functionValue = {functionValue}");


        }
        public static void MyOtherFunction()
        {
         
            // output vasiable to console
            Console.WriteLine($"From outside: outsideValue = {outsideValue}");
            //Console.WriteLine($"From outside: functionValue = {functionValue}");


        }
    }
}
