using System;
using System.Collections.Generic;
using System.Text;

namespace Atm4
{
    class Account
    {
        //
        private decimal _ballance;

        

        public Account(decimal balance)
        {
            Balance = balance;
        }

        //eval initail balance
        public decimal Balance
        {
            get { return _ballance;  }
            set
            {
                if (value >= 0 )
                {
                    _ballance = value;
                }
                else
                {
                    throw new Exception("Balance can not be negative!");
                }
            }
        }

        //overridable method to add to balance
        public virtual void Credit(decimal amount)
        {
            if ( amount > 0 )
            {
                Balance += amount;
            }
            else
            {
                throw new Exception("Credit amount must be greater than zero");
            }
        }

        //public virtual decimal Debit(decimal amount)
        public virtual bool Debit(decimal amount)
        {
            bool OK = true;
            if ( Balance - amount >= 0)
            {
                Balance -= amount;
                OK = true;
            }
            else
            {
                Console.WriteLine("Insufficient Funds for withdrawl");
                OK = false;
            }
            return true;
        }

    }
}



////Accounts array  Acc#, Name, Current Checking Balance, Current Savings Balance, ckLastDate, savLastDate
//string[,] customerAccounts = new string[3,6] { "Tom Account#..............0", "Dick", "Harry" };

//{ { "Tom Jones", "Dick Clark", "Harry Styles" }, { "three", "four" },
//{ "five", "six" } };
//public LoadAccounts()
//{
//    //Balance = balance;
//}