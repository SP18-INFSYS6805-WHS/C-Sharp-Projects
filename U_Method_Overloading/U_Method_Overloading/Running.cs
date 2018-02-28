using System;
namespace U_Method_Overloading
{
    class Running
    {
        public int Run(int miles)
        {
            return miles;
        }

        public int Run(int speed, int distance)
        {
            return speed + distance;
        }

        public void Run(int pace, int location1, int location2)
        {
            
        }
        public decimal Run(decimal a, decimal b)
        {
            return a + b;
        }

    }
}
