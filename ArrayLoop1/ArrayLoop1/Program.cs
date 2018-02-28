using System;

namespace ArrayLoop1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Array Loop 1");

            string[] Student = new string[] { "Tom", "Dick", "Harry" };

            for (int i = 0; i < Student.Length; i++)
            {
                Console.WriteLine(Student[i]);
            }



        }
    }
}
