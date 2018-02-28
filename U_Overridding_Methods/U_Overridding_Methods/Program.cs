using System;

namespace U_Overridding_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Overridding methods App");
            Console.WriteLine();
            Console.WriteLine();

            ////instanciate the Base class
            //Base myBase = new Base();
            //myBase.Print();

            //instanciate the derived class
            Derived myDerived = new Derived();
            myDerived.Print();

        }
    }
}
