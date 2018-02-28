using System;
namespace U_Inheritance
{
    class Car : Auto  // Kinda the same as extends
    {
        public int Speed;
        public string Transmission;

        public void Acceleration()
        {
            Console.WriteLine("My car accelerates at 0 to 60 in 4.3 seconds");

        }
    }
}
