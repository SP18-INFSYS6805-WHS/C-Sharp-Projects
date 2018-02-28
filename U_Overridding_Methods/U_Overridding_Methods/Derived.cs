using System;
namespace U_Overridding_Methods
{
    class Derived : Base
    {
        public override void Print()
        {
            Console.WriteLine("This is my Derived class!");
            //base.Print();
        }
    }
}
