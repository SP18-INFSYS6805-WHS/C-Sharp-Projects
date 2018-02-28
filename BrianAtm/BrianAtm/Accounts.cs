using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_C_Sharp
    {
        class Account
        {

            ATM callATM = new ATM();



            DateTime firstDate; // = 2010, 8, 25; //for handling the initial date created by user
            DateTime secondDate;
            double initBalance;
            double subtract;
            private double balance;
            private double depositMe;
            



            //DateTime fDate = new DateTime(1994, 8, 25);
            //int jDate; = fDate.Year* 1000 + dt.DayOfYear;  //    

            public Account()
            {
                initBalance = 100;
            }


            public void Menu()
            {
                int choice;
                int loopChoice = 0; // While loop variable

                while (loopChoice != 4)
                {

                    Console.WriteLine("Choose an option: \n");
                    Console.WriteLine("    1) Deposit");
                    Console.WriteLine("    2) Withdraw");
                    Console.WriteLine("    3) Check Balance");
                    Console.WriteLine("    4) Exit");

                    loopChoice = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine(choice);
                    if (loopChoice == 1) //ENTER DEPOSIT METHOD
                    {
                        Console.WriteLine("Your initial balance is currently: " + initBalance);
                        Deposit();

                    }

                    if (loopChoice == 2) // ENTER WITHDRAW METHOD
                    {
                        Withdraw();

                    }

                    if (loopChoice == 3) //ENTER CHECKBALANCE METHOD
                    {
                        CheckBal();

                    }

                    if (loopChoice == 4) //TO GO BACK TO TOP MENU
                    {
                        callATM.TopMenu();
                    }


                }//END WHILE LOOP


            } //END MENU METHOD


            public void Deposit()
            {   
                

                Console.WriteLine("How much would you like to deposit?");
                Account callAcc = new Account();
                balance = Convert.ToDouble(Console.ReadLine()) + initBalance;
                //callAcc.setBalance(balance);

                Console.WriteLine("Your balance is now: " + balance);

            } //END DEPOSIT METHOD


            public void Withdraw()
            {
                Console.WriteLine("How much would you like to withdraw?");
                subtract = Convert.ToDouble(Console.ReadLine());

                balance = (initBalance + balance) - subtract;
                Console.WriteLine("Your new balance is {0}", balance);
            }

            public void CheckBal()
            {

            //  *****  No need to add to balance here just display it
            //  The way it was, everytime you checked the balance it would add 100
            //  balance = initBalance + balance;

            Console.WriteLine("Your balance is: {0}", balance);

            DateTime thisDay = DateTime.Today;


            //DateTime dateString = "10/22/2015";
            //DateTime myDate; // 1/1/0001 12:00:00 AM 
            //bool isSuccess4 = DateTime.TryParseExact(dateString, "MM/dd/yyyy", provider, DateTimeStyles.None, out dateTime13);



            DateTime timeUtc = DateTime.UtcNow;

            Console.WriteLine("UTC is: " + timeUtc); 
            Console.WriteLine(DateTime.UtcNow.ToString()); 




            int jDate = thisDay.DayOfYear;

            //string today = thisDay.ToString();

            Console.WriteLine("Today is: " + DateTime.Now); 
            Console.WriteLine("Today Julian date is: " + jDate); 

            DateTime dt = new DateTime(1994, 8, 25);
            int julian = dt.Year * 1000 + dt.DayOfYear;

            //JulianCalendar myCal = new JulianCalendar();
            // Display the date in the default (general) format.

            Console.WriteLine(DateTime.UtcNow.ToString()); 

      

            //myDate = new DateTime(2015, 4, 13);
            //var b = string.Format("{0:yyyy}{1:D3}", myDate, myDate.DayOfYear); //1994237



            } //END CHECK BALANCE METHOD



            public void calcInterest()
            {

            } //END CALC INTEREST METHOD


            //THIS METHOD TAKES IN THE FIRST DATE ENTERED BY THE USER
            //public void InitDate()
            //{


            //    Console.WriteLine("Please enter today's date in mm/dd/yyyy format:  \n");
            //    firstDate = DateTime.Parse(Console.ReadLine());

            //    Console.WriteLine("You entered today's date as: {1}", firstDate);

            //} END INITIAL DATE METHOD



            //**************** SETTERS & GETTERS FOR PRIVATE FIELDS ****************

            public void setBalance(double bal)
            {
                balance = bal + initBalance;
            }
            public double getBalance()
            {
                return balance;
            }



            public void setDepositAmmount(double depo)
            {
                depositMe = depo;
            }
            public double getDepositAmmount()
            {
                return depositMe;
            }







            //**********************************************************************



        } //END ACCOUNT CLASS


    }
