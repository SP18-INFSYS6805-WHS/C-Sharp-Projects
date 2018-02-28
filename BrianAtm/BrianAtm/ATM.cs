using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_C_Sharp
{
    //            !!!!!!!!!!! PERSONAL NOTE !!!!!!!!!!!!!!!!!
    //         LOOK AT A CALC INTEREST METHOD EXAMPLE IN FILES!
    class ATM
    {

        static ATM call = new ATM();

        /* new Account[3]; */


        static void Main(string[] args)
        {

            call.TopMenu();

        } //END MAIN METHOD

        public void TopMenu()
        {



            int choice;

            Console.WriteLine("                               _____________________________________________________________");
            Console.WriteLine("                              |                 *********************                       |");
            Console.WriteLine("                              |                 *  Money Talks ATM  *                       |");
            Console.WriteLine("                              |                 *  Established 2018 *                       |");
            Console.WriteLine("                              |                 *********************                       |");
            Console.WriteLine("                              |_____________________________________________________________|");
            Console.WriteLine("                              |                                                             |");
            Console.WriteLine("                              |           Please enter an option below:                     |");
            Console.WriteLine("                              |                1) Load Accounts                             |");
            Console.WriteLine("                              |                2) Populate Accounts                         |");
            Console.WriteLine("                              |                3) Choose Account                            |");
            Console.WriteLine("                              |                4) Exit                                      |");
            Console.WriteLine("                              |                                                             |");
            Console.WriteLine("                             <_______________________________________________________________>");
            Console.WriteLine("\n\n");

            choice = Convert.ToInt32(Console.ReadLine());



            if (choice == 1) //option to Load Accounts
            {
                LoadAccounts();
            }

            if (choice == 2) //option to Populate Accounts
            {
                PopulateAccounts();
            }

            if (choice == 3) //option to Choose Account
            {
                ChooseAccount();
            }

            else //To exit the app entirely
            {
                Environment.Exit(0);
            }

        } //END TOP MENU METHOD


        public void LoadAccounts()
        {

            Console.WriteLine("This is load accounts");




        } // END LOAD ACCOUNTS METHOD


        public void PopulateAccounts()
        {
            Console.WriteLine("This is Populate accounts");


        } // END POPULATE ACCOUNTS METHOD


        public void ChooseAccount()
        {
            Account[] accArray = { new Account(), new Account(), new Account() }; //DECLARE ACCOUNT ARRAY WITH 3 ACCOUNTS

            int accChoice = 0;
            Console.WriteLine("Which account would you like to access? \n");

            Console.WriteLine("Account#..............0");
            Console.WriteLine("Account#..............1");
            Console.WriteLine("Account#..............2");
            Console.WriteLine("");

            Console.WriteLine("Please enter an account number: ");

            accChoice = Convert.ToInt32(Console.ReadLine());

            if (accChoice == 0)
            {
                accArray[accChoice].Menu();
            }
            if (accChoice == 1)
            {
                accArray[accChoice].Menu();
            }
            if (accChoice == 2)
            {
                accArray[accChoice].Menu();
            }


        } //END CHOOSE ACCOUNT METHOD

    } //END ATM CLASS
}






/*
 *  int input = 0;
            Console.WriteLine("Please select a student account: 0, 1, or 2");
            int index = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("1) Calculate Average");
                Console.WriteLine("2) Calculate Letter Grade");
                Console.WriteLine("3) Display Student");
                Console.WriteLine("4) Exit");

                input = Convert.ToInt32(Console.ReadLine());

                if( input == 1)
                {
                    stuArray[index].calcAvg();
                }
                else if (input == 2)
                {

                    Console.WriteLine("Your letter grade is: {0}", stuArray[index].calcLetterGrade());
                    stuArray[index].calcLetterGrade();
                }
                else if (input == 3)
                {
                    stuArray[index].displayStudent();
                }



            } while (input != 4); //END DO-WHILE LOOP
*/





// *****  No need to add to balance here just display it
// The way it was, everytime you checked the balance it would add 100
//balance = initBalance + balance;

//Console.WriteLine("Your balance is: {0}", balance);


//                var myDate = new DateTime(1994, 8, 25);
//var a = string.Format("{0:yyyy}{1:D3}", myDate, myDate.DayOfYear); //1994237
