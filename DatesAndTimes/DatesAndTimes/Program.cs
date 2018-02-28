using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            var birthday = new DateTime(1969, 10, 17);

            Console.WriteLine(birthday);


            // time arithmatic

            var difference = DateTime.Now - birthday;

            Console.WriteLine(difference);

            Console.WriteLine(18201 - difference.Days);

            Console.WriteLine(difference.Days / 365);

            Console.WriteLine(18201 / 365);

            var someTime = new DateTime(2018, 01, 18, 4, 35, 32);

            Console.WriteLine(someTime.AddMinutes(2000));


            Console.WriteLine(birthday.ToLongDateString());


            Console.WriteLine(DateTime.Now.Subtract(difference).ToLongDateString());


        }
    }
}
