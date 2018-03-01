using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Atm4
{
    class Savings : Account
    {
        
        private DateTime lastDate = new DateTime(2010,10,28);
        private DateTime newDate = new DateTime(2018, 2, 28);



        private decimal _interestRate;

        public Savings(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        //property
        public decimal InterestRate
        {
            get { return _interestRate;  }
            set
            {
                if ( value > 0 )
                    _interestRate = value;
                else
                    throw new Exception("Interest Rate must be greater that zero!");   
            }
        }

        //Calc interest

        public decimal CalcInterest()
        {
            Console.WriteLine("Days Difference inside CalcInterest: {0}", CalcDays());

            Console.WriteLine("Interest rate inside CalcInterest {0}", InterestRate);

            Console.WriteLine("The daily Interest rate should be {0}", ( InterestRate / 365 ));


            decimal interest = ((InterestRate / 365) * CalcDays());                     //InterestRate / 365 is to convert APR to a daily rate 

            Console.WriteLine("The interest in CalcInterest: {0}", interest);

            return Balance * InterestRate;
        }

        // Calc number of days since last update
        public int CalcDays()
        {

            //Console.WriteLine("Enter a date in the future in this format (2018/2/22) : ");
            //string input = Console.ReadLine();
            //DateTime newDate = Convert.ToDateTime(input);

            DateTime curDate = DateTime.UtcNow;
            Console.WriteLine("            Today's date..{0}", curDate);
            Console.WriteLine("            Last transaction date..{0}", lastDate);

            Console.WriteLine();

            //TimeSpan ts = newDate.ToUniversalTime().Subtract(curDate.ToUniversalTime()); // future date - current date
            TimeSpan ts = curDate.ToUniversalTime().Subtract(lastDate.ToUniversalTime());  // current date - last date


            int daysDif = Convert.ToInt32(Math.Floor(ts.TotalDays));   //get rid of partial days

            Console.WriteLine("                  Days Difference: " + daysDif);

            Console.WriteLine(curDate);

            lastDate = curDate.ToUniversalTime();

            Console.WriteLine("                       In CalcDays   dtDayOne is now: {0}", lastDate);

            return daysDif;







            //DateTime curDate = DateTime.UtcNow;
            //Console.WriteLine("last date..{0}", dtDayOne);
            //Console.WriteLine("Current date..{0}", curDate);
            //TimeSpan ts = curDate.ToUniversalTime().Subtract(dtDayOne.ToUniversalTime());
            //int daysDif = Convert.ToInt32(Math.Floor(ts.TotalDays));   //get rid of partial days
            //Console.WriteLine("Days Difference: " + daysDif);
            //Console.WriteLine(dtDayOne);
            //dtDayOne = curDate.ToUniversalTime();
            //Console.WriteLine("In CalcDays   dtDayOne is now: {0}", dtDayOne);
            //return daysDif;

        }



    }
}
