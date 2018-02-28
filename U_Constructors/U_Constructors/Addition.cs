using System;
namespace U_Constructors
{
    class Addition
    {
        private int firstNumber;
        private int secondNumber;



        //creating a default constructor
        public Addition()
        {
            Console.WriteLine("This is my default constructor.");
            firstNumber = 3;
            secondNumber = 5;
        }

        public Addition(int a, int b)
        {
            Console.WriteLine("This is an overloaded constructor taking in two values!");

            firstNumber = a;
            secondNumber = b; 
        }

        public int AddNumbers()
        {
            return firstNumber + secondNumber;
        }
    }
}
