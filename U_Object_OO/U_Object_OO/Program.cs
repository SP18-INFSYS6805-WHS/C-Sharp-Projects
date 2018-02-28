using System;

namespace U_Object_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Object OO classes and methods App\nAnd getters and setters");
            Console.WriteLine("");
            Console.WriteLine("");

            Computer myComputer = new Computer();

            string manuFact = "Dell";

            //myComputer.manufacturer = "Dell";
            myComputer.Manufacturer(manuFact);
        }
    }
}
