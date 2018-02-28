using System;

namespace Assignment_1_ATM

{
    public class Atm
    {
        public Atm()
        {
            Console.WriteLine("This is the ATM class!");
            Console.WriteLine("please enter the number of the action you want to perform");


            Console.WriteLine("1 - To check account balances ");
            Console.WriteLine("2 - Savings ");
            Console.WriteLine("3 - Checking ");
            Console.WriteLine("4 - Transfers ");
            Console.WriteLine("5 - Check interest rates ");
            //Console.WriteLine("");
            Console.WriteLine("6 - To Exit the program ");

                      
            string key;
            while((key = Console.ReadKey().KeyChar.ToString()) != "6")            
            {
                int keyValue;                
                int.TryParse(key, out keyValue);

                MenuItem(keyValue);
            }
        }

        private static void MenuItem(int keyValue)
        {
            switch (keyValue)
            {
                case 1:
                    Action1();
                    break;
                case 2:
                     Action2();
                    break;
                case 3:
                    Action3();
                    break;
                case 4:
                    Action4();
                    break;
                case 5:
                    Action5();
                    break;
            }
        }

        private static void Action1(){

            GetBal();

        }
        private static void Action2()
        {
            Console.WriteLine("Savings");
        }
        private static void Action3()
        {
            Console.WriteLine("Checking");
        }
        private static void Action4()
        {
            Console.WriteLine("Transfers");
        }
        private static void Action5()
        {
            Console.WriteLine("Interest Rates");
        }




    }
}
