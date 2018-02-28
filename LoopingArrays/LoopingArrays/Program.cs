using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] myArray = new string[] { "Mike", "Pat", "Janet", "Matt", "Bill" };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Hello, {myArray[i]}!");
            }



            // For each loop eliminates the need for an itterator

            foreach (string name in myArray) 
            {
                Console.WriteLine($"Good bye, {name}.");
            }



            //Console.WriteLine(myArray[5]);

        }
    }
}
