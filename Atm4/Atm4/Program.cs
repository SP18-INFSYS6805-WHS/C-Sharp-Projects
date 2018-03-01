using System;
using System.Globalization;

namespace Atm4
{
    class Program
    {


        // Start of the main method
        static void Main(string[] args)
        {
            Console.WriteLine("ATM App version 4");

            Console.WriteLine();
            Console.WriteLine();


            decimal beginingSavingsBal = 1000.25M;  //sample begining savings balance
            decimal savCredit = 400.24M;            //sample savings deposit
            decimal savDebit = 40.75M;              //sample savings withdrawl

            decimal savIntRate = 0.005M;            //sample savings interest rate  4.5%
            decimal ckIntRate = 0.0005M;             //sample checking interest rate  0.75%

            decimal totalInterest = 0.0M;           //total interest

            decimal beginingCheckBal = 820.64M;     //sample begining checking balance
            //decimal checkFee = 0.00M;               //sample begining checking balance
            decimal checkDeposit = 785.23M;         //sample checking deposit
            decimal checkDebit = 65.87M;            //sample checking withdrawl


            ////Render savings account

            Savings sa = new Savings(beginingSavingsBal, savIntRate);


            Console.WriteLine("Savings begining balance: {0:C}", sa.Balance);

            totalInterest = sa.CalcInterest(); //Calculate interest

            Console.WriteLine("Total interest: {0:C}", totalInterest);

            sa.Credit(totalInterest); //Credits the interest to the balance

            Console.WriteLine("Savings balance after added interest of {0:C}: {1:C}", totalInterest, sa.Balance);

            Console.WriteLine();

            //Render checking account
            Checking ca = new Checking(beginingCheckBal, ckIntRate);
            Console.WriteLine("Checking begining balance: {0:C}", ca.Balance);
            ca.Credit(checkDeposit);    //make a checking deposit (- Fee)
            Console.WriteLine("Checking balance after deposit of {0:C}: {1:C}", checkDeposit, ca.Balance);
            ca.Debit(checkDebit);    //make a checking withdrawl (- Fee)
            Console.WriteLine("Checking balance after withdrawl of {0:C}: {1:C}", checkDebit, ca.Balance);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();






            //DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;
            //DateTime date1 = new DateTime(2011, 5, 1);
            //Console.WriteLine("Original Short Date Pattern:");
            //Console.WriteLine("   {0}: {1}", dtfi.ShortDatePattern,
            //                                 date1.ToString("d", dtfi));
            //dtfi.DateSeparator = "/";
            //dtfi.ShortDatePattern = @"yyyy/MM/dd";
            //Console.WriteLine("Revised Short Date Pattern:");
            //Console.WriteLine("   {0}: {1}", dtfi.ShortDatePattern,
            //                                 date1.ToString("d", dtfi));


        }

        





    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_1_C_Sharp
//{
//    //            !!!!!!!!!!! PERSONAL NOTE !!!!!!!!!!!!!!!!!
//    //         LOOK AT A CALC INTEREST METHOD EXAMPLE IN FILES!
//    class ATM
//    {

//        static ATM call = new ATM();

//        /* new Account[3]; */


//        static void Main(string[] args)
//        {

//            call.TopMenu();

//        } //END MAIN METHOD









//        /// <summary>
//        /// ///////
//        /// </summary>


//        public void LoadAccounts()
//        {

//            Console.WriteLine("This is load accounts");




//        } // END LOAD ACCOUNTS METHOD


//        public void PopulateAccounts()
//        {
//            Console.WriteLine("This is Populate accounts");


//        } // END POPULATE ACCOUNTS METHOD


//        public void ChooseAccount()
//        {
//            Account[] accArray = { new Account(), new Account(), new Account() }; //DECLARE ACCOUNT ARRAY WITH 3 ACCOUNTS

//            int accChoice = 0;
//            Console.WriteLine("Which account would you like to access? \n");

//            Console.WriteLine("Account#..............0");
//            Console.WriteLine("Account#..............1");
//            Console.WriteLine("Account#..............2");
//            Console.WriteLine("");

//            Console.WriteLine("Please enter an account number: ");

//            accChoice = Convert.ToInt32(Console.ReadLine());

//            if ( accChoice == 0 )
//            {
//                accArray[accChoice].Menu();
//            }
//            if ( accChoice == 1 )
//            {
//                accArray[accChoice].Menu();
//            }
//            if ( accChoice == 2 )
//            {
//                accArray[accChoice].Menu();
//            }


//        } //END CHOOSE ACCOUNT METHOD

//    } //END ATM CLASS
//}






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



//public static void TopMenu()
//{



//    int choice;

//    Console.WriteLine("                               _____________________________________________________________");
//    Console.WriteLine("                              |                 *********************                       |");
//    Console.WriteLine("                              |                 *  Money Talks ATM  *                       |");
//    Console.WriteLine("                              |                 *  Established 2018 *                       |");
//    Console.WriteLine("                              |                 *********************                       |");
//    Console.WriteLine("                              |_____________________________________________________________|");
//    Console.WriteLine("                              |                                                             |");
//    Console.WriteLine("                              |           Please enter an option below:                     |");
//    Console.WriteLine("                              |                1) Load Accounts                             |");
//    Console.WriteLine("                              |                2) Populate Accounts                         |");
//    Console.WriteLine("                              |                3) Choose Account                            |");
//    Console.WriteLine("                              |                4) Exit                                      |");
//    Console.WriteLine("                              |                                                             |");
//    Console.WriteLine("                             <_______________________________________________________________>");
//    Console.WriteLine("\n\n");

//    choice = Convert.ToInt32(Console.ReadLine());

//    if ( choice == 1 ) //option to Load Accounts
//    {
//        //LoadAccounts();
//    }
//    if ( choice == 2 ) //option to Populate Accounts
//    {
//        //PopulateAccounts();
//    }
//    if ( choice == 3 ) //option to Choose Account
//    {
//        ///ChooseAccount();
//    }
//    else //To exit the app entirely
//    {
//        Environment.Exit(0);
//    }

//} //END TOP MENU METHOD