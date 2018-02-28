using System;

namespace U_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Inheritance, Encapsulation App");
            Console.WriteLine();
            Console.WriteLine();

            //first thing is instanciate the truck class
            Truck myTruck = new Truck();

            myTruck.Make = "Chevy";
            myTruck.Model = "Silverado";
            myTruck.Year = 2015;
            //// getter below for private troque for encapsulation
            //myTruck.Torque = 925;
            myTruck.TowingCapacity = 21000;
            myTruck.Print();
            myTruck.Engine();
            //Console.WriteLine("My torque is: {0} ", myTruck.Torque);
            //modified to get private torque
            Console.WriteLine("My torque is: {0} ", myTruck.GetTorque());

            Console.WriteLine("My towing capacity is: {0} ", myTruck.TowingCapacity);

            // a getter for private troque for encapsulation
            myTruck.GetTorque();


            Car myCar = new Car();

            myCar.Make = "Nissan";
            myCar.Model = "Altima";
            myCar.Year = 2016;
            myCar.Print();
            myCar.Speed = 90;
            myCar.Transmission = "Manual";

            Console.WriteLine("I was driving at {0} miles per hour.", myCar.Speed);
            Console.WriteLine("My car has a {0} transmission.", myCar.Transmission);



        }
    }
}
