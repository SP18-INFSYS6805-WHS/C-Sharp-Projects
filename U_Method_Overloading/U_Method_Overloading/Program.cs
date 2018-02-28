using System;

namespace U_Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Method Overloading App.");
            Console.WriteLine("");
            Console.WriteLine("");

            Running r = new Running();
            Console.WriteLine("The totoal number of miles ran this month is {0} miles.", r.Run(30));
            Console.WriteLine("The average speed was: {0} miles per hour. The longest distance was: {1} miles", r.Run(5), r.Run(10));

        }
    }
}
