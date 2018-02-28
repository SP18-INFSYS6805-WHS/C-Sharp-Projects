using System;

namespace GradeBook_Multi_Student
{
    class Student
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Gradebook - Multiple Students App!");
            Console.WriteLine();
            Console.WriteLine();

            //char appRun = null;


            //do
            //{
                string[] stuArray = new string[] { "Mike", "Pat", "Janet", "Matt", "Will" };
                double[,] gradeArray = new double[] { { 87.2, 78.56 }, { 82.4, 88.7 }, { 92.2, 84.56 }, { 73.8, 74.72 }, { 97.2, 92.56 } };

                foreach (var item in stuArray)
                {
                    Console.WriteLine(item);
                }




           // } while (appRun != 'q');

           






            //Console.Write("Please enter the student first name: ");
            //string stuName = Console.ReadLine().Trim();
            //Console.Write("Please enter grade for Exam 1: ");
            //string examOne = Console.ReadLine().Trim();
            //double Num;
            //bool isNum = double.TryParse(examOne, out Num);
            //if (isNum)
            //{
            //    if (Num <= 100)
            //    {
            //        //Console.WriteLine(Num.ToString() + " is a valid number!");
            //        Console.WriteLine("You entered {0} for Exam 1.", examOne);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input! Please enter a grade of 0.0-100.0!");
            //        //Console.ReadLine();
            //        System.Environment.Exit(1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a grade of 0.0-100.0!");
            //    //Console.ReadLine();
            //    System.Environment.Exit(1);
            //}
            //Console.Write("Please enter grade for Exam 2: ");
            //string examTwo = Console.ReadLine().Trim();
            //double Num2;
            //bool isNum2 = double.TryParse(examTwo, out Num2);
            //if (isNum2)
            //{
            //    if (Num2 <= 100)
            //    {
            //        //Console.WriteLine(Num.ToString() + " is a valid number!");
            //        Console.WriteLine("You entered {0} for Exam 2.", examTwo);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input! Please enter a grade of 0.0-100.0!");
            //        System.Environment.Exit(1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a grade of 0.0-100.0!");
            //    System.Environment.Exit(1);
            //}
            //GradeBook myStudent = new GradeBook();
            //myStudent.Name = stuName;
            //myStudent.Exam1 = examOne;
            //myStudent.Exam2 = examTwo;
            //Console.WriteLine("Student name: {0}", myStudent.Name);
            //Console.WriteLine("Student Exam 1: {0}", myStudent.Exam1);
            //Console.WriteLine("Student Exam 2: {0}", myStudent.Exam2);
            //Console.WriteLine("Student Exam average: {0}", myStudent.CalcAverage(examOne, examTwo));
        }
    }
}
