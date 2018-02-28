using System;
using System.Linq;

namespace ATM_2_15
{
    class ATM
    {
        const string welcome = "This is some kind of welcome message";


        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the number of the tsk you wish to do: ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("1 - See available accounts: ");
            Console.WriteLine("2 - Savings: ");
            Console.WriteLine("3 - Checking: ");
            Console.WriteLine("4 - Transfers: ");
            Console.WriteLine("5 - Deposits: ");
            Console.WriteLine("6 - Witdrawls: ");
            Console.WriteLine("7 - Interest: ");
            Console.WriteLine("9 - Exit Program: ");

            var userInput = Console.ReadLine();
            Console.WriteLine(userInput);
            //Account acc = new Account();



            while (userInput != "9")
            {
                switch (userInput)
                {
                    case "1": // correction 1

                        Account.Menu2 acc = new Account.Menu2();

                        //foreach (var item in Accounts)
                        //{
                        //    int x = 0;
                        //    Int32.TryParse(item, out x);
                        //    Console.WriteLine("X is: " + x);
                        //    Console.WriteLine("item is: " + item);

                        //    Console.WriteLine("Account Number: {0}  Name: {1}", Accounts[x, 0], Accounts[x, 1]);
                        //}
                        break;

                    default:
                        Console.WriteLine(" Invalid Entry");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}




//        }
//        
            
//    }
//}


                    //case "1": // correction 1
                    //    for (int i = 0; i<aTAccounts.Length / 4; i++)
                    //    {
                    //        Console.WriteLine("Account Number: {0}  Name: {1}", Accounts[i, 0], Accounts[i, 1]);
                    //    } 

                    //    //ShowAccounts();
                    //    break;


                    //default:
                        //Console.WriteLine(" You did not type a or b");
                        //Console.WriteLine();
                        //Console.ReadLine();
                        //break;




           

   