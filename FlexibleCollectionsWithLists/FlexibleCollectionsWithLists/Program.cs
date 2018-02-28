using System;
using System.Collections.Generic;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] myArray = new string[] { "Mike", "Pat", "Janet", "Matt" };

 

            // For each loop eliminates the need for an itterator

            foreach (string element in myArray) Console.WriteLine(element);


            myArray[0] = "Tim";

            Console.WriteLine(" ");
            foreach (string element in myArray) Console.WriteLine(element);

            Console.WriteLine(" ");
            // List have to be imported look at "using System.Collections.Generic;" above







            List<string> myList = new List<string>();
            myList.Add("Rocket");
            myList.Add("Scout");
            myList.Add("Bus");


            foreach (string element in myList) Console.WriteLine(element);

            Console.WriteLine(" ");
                       
            // Print single items
            Console.WriteLine(myList[1]);
            Console.WriteLine(" ");
            // to count the number of items in a list
            int c = myList.Count;
            Console.WriteLine(c);

            myList.Insert(1, "Suck");

            foreach (string element in myList) Console.WriteLine(element);

            Console.WriteLine(" ");


            // to remove items

            myList.Remove("Suck");

            foreach (string element in myList) Console.WriteLine(element);

            Console.WriteLine(" ");

            myList.RemoveAt(1);

            foreach (string element in myList) Console.WriteLine(element);

            Console.WriteLine(" ");



        }
    }
}
