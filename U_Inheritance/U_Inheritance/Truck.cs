using System;
namespace U_Inheritance
{
    class Truck : Auto  //like extends Auto
    {

        //public int Torque;  changing for encapsulation
        private int Torque = 835;
        public int TowingCapacity;

        public int GetTorque()
        {
            return Torque;
        }

        public void Engine()
        {
            Console.WriteLine("This is a big engine (BFE)!");
        }
    }
}
