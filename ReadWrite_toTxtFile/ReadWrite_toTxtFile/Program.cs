using System;
using System.IO;

namespace ReadWrite_toTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {



            string line;
            try 
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");
                StreamReader sr = new StreamReader(path);

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();


                }
                sr.Close();
                //Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.WriteLine("Executing finally block.");




        }
    }
}
