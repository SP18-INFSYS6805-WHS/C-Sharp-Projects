using System;

namespace WhileLoops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int myValue = 0;

            while (myValue < 101) 
            {
                if (myValue % 4 == 0)
                {
                    Console.WriteLine(myValue);

                }

                //myValue = myValue + 1;
                //myValue += 1;

                myValue++;


            }


            // Do while
            int myBadValue = 0;

            do
            {
                Console.WriteLine("This will reun at least once");

                myBadValue++;
            }
            while (myBadValue != 10);

        }
    }
}
