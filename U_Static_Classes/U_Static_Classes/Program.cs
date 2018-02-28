using System;

namespace U_Static_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Classes App.");
            Console.WriteLine();


            //Student myStudent = new Student();
            //// can't choose GradeAverage because it is static
            //myStudent.GradeAverage = 85;

            Student.GradeAverage = 85;
            Console.WriteLine("The student average is: {0}", Student.GradeAverage);
            Student.Gender = "Male";

            Student.GradeAverage = 92;
            Student.SaySomething();

            Console.WriteLine("The student average is: {0}", Student.GradeAverage);
            Console.WriteLine("Student gender is: {0}", Student.Gender);
        }
    }
}
