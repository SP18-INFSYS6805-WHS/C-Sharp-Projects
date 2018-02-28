using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AddingClasses
{

    class MyCustomClass
    {

        public string petName;
        private int age;


        public MyCustomClass()
        {
            Console.WriteLine("A new instance of MyCustomClass created");

        }

        public void Speak()
        {
            Console.WriteLine($"{petName} says, \"Meow\"");

        }

        // creating a public method that will return the private age
        // which is private to this class

        public int GetAge()
        {
            return age;
        }

    }
}
