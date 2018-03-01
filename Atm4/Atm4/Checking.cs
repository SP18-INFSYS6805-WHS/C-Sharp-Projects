using System;
using System.Collections.Generic;
using System.Text;

namespace Atm4
{
    class Checking : Account
    {

        private DateTime dtDayOne = new DateTime(2010,05,14);



        private decimal _interestRate;

        public Checking(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate;
        }

        //property
        public decimal InterestRate
        {
            get { return _interestRate; }
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

            decimal interest = (InterestRate / 365) * CalcDays();
            Console.WriteLine("The interest in CalcInterest: {0}", interest);
            return Balance * InterestRate;
        }

        // Calc number of days since last update
        public int CalcDays()
        {
            DateTime curDate = DateTime.UtcNow;
            //Console.WriteLine("last date..{0}", dtDayOne);
            //Console.WriteLine("Current date..{0}", curDate);
            TimeSpan ts = curDate.ToUniversalTime().Subtract(dtDayOne.ToUniversalTime());
            int daysDif = Convert.ToInt32(Math.Floor(ts.TotalDays));   //get rid of partial days
            //Console.WriteLine("Days Difference: " + daysDif);
            // Console.WriteLine(dtDayOne);
            dtDayOne = curDate.ToUniversalTime();
            Console.WriteLine("dtDayOne is now: {0}", dtDayOne);
            return daysDif;

        }



    }
}
