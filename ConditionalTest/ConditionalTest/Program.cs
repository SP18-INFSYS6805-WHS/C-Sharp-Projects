using System;

namespace ConditionalTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Boolean knowThisStuff = true;


            Console.WriteLine($"The value of knowThisStuff: {knowThisStuff}");


            if (knowThisStuff)
            {
                Console.WriteLine("I know it!");

            }

            // if there is only one line you can take this shortcut without {}
            if (knowThisStuff) Console.WriteLine("I still know it!");

            int myValue = 5;
            Console.WriteLine($"myValue is: {myValue}");

            if (myValue == 5)
            {
                Console.WriteLine($"The condition of (myValue == 5) is true!");
            }
            else
            {
                Console.WriteLine($"The condition of (myValue == 5) is false!");
            }



            if (myValue < 5)
            {
                Console.WriteLine($"The condition of (myValue < 5) is true!");
            }
            else
            {
                Console.WriteLine($"The condition of (myValue < 5) is false!");
            }




            if (myValue != 5)
            {
                Console.WriteLine($"XXXXXXThe condition of (myValue != 5) is true!");
            }
            else if (myValue < 5)
            {
                Console.WriteLine($"The condition of (myValue < 5) is true!");
            }
            else if (myValue > 5)
            {
                Console.WriteLine($"The condition of (myValue > 5) is true!");
            }




            if (myValue != 5)
            {
                Console.WriteLine($"The condition of (myValue != 5) is true!");

                if (myValue < 5)
                {
                    Console.WriteLine($"The condition of myValue is less than 5");
                    return;
                }
               
                    Console.WriteLine($"The condition of myValue is greater than 5");
                    return;


            }
        }
    }
}
