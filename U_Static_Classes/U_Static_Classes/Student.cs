using System;
namespace U_Static_Classes
{
    //class Student
    //{
    //    //currently Static so can't be used from elsewhere
    //    public static int GradeAverage;
    //    public string Gender;

    //    public static void SaySomething()
    //    {
    //        Console.WriteLine("I want to post a higher grade average.");

    //    }

    //}

    // creating a 'static' class Student
    static class Student
    {
        public static int GradeAverage;
        //need to make Gender a static field
        public static string Gender;

        public static void SaySomething()
        {
            Console.WriteLine("I want to post a higher grade average.");

        }

    }
}
