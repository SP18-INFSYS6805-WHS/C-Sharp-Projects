using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCustomClass;



namespace AddingClasses
{

    class Program
    {

        static void Main(string[] args)
        {
            MyCustomClass pet = new MyCustomClass();
            pet.petName = "Rocket";
            pet.Speak();
            //pet.age;    // wont work because age is private
            Console.WriteLine($"{pet.petName} is {pet.GetAge()} years old.");
        }
    }
}