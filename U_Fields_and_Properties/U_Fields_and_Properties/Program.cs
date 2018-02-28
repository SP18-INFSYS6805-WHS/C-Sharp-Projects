using System;

namespace U_Fields_and_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U Fields and Properties App using get; set; ");

            Console.WriteLine("");
            Console.WriteLine("");

            Student myStudent = new Student();

            //sets the property
            myStudent.Name = "Will";

            //calls the get accessor and return name
            Console.WriteLine("The student's name is {0}", myStudent.Name);

        }
    }
}
